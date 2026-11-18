using System.Globalization;
using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite;

public static class Program
{
    public static void Main()
    {
        Dictionary<string, ISoldier> soldiersById = new();
        var soldiersInOrder = new List<ISoldier>();
        try
        {
            var input = ReadRequiredLine();
            while (input != "End")
            {
                var data = input.Split();

                ISoldier soldier;
                try
                {
                    soldier = data[0] switch
                    {
                        "Private" => CreatePrivateSoldier(data),
                        "LieutenantGeneral" => CreateLieutenantGeneral(data, soldiersById),
                        "Engineer" => CreateEngineer(data),
                        "Commando" => CreateCommando(data),
                        "Spy" => CreateSpy(data),
                        _ => throw new InvalidOperationException("Unrecognized soldier type")
                    };
                }
                catch (InvalidCorpsException)
                {
                    // Invalid corps: skip this line and continue with the next one.
                    input = ReadRequiredLine();
                    continue;
                }
                soldiersById.Add(soldier.Id, soldier);
                soldiersInOrder.Add(soldier);

                input = ReadRequiredLine();
            }

            foreach (var soldier in soldiersInOrder)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static ISoldier CreateCommando(string[] data)
    {
        var commando = new Commando(data[1], data[2], data[3], ParseDecimal(data[4]),
            ParseCorps(data[5]));
        // Fields 0-5 (type, id, names, salary, corps) are already used above.
        // From index 6 the line holds missions as pairs: <codeName> <state>.
        // i += 2 jumps from one pair to the next; i < data.Length - 1 guarantees
        // that data[i + 1] (the state) exists, so a dangling code name is ignored.
        for (var i = 6; i < data.Length - 1; i += 2)
        {
            if (!Enum.TryParse(data[i + 1], out MissionState missionState)) continue;
            var mission = new Mission(data[i], missionState);
            commando.AddMission(mission);
        }
        return commando;
    }

    private static ISoldier CreateLieutenantGeneral(string[] data, Dictionary<string, ISoldier> soldiersById)
    {
        var lieutenantGeneral = new LieutenantGeneral(data[1],
            data[2], data[3], ParseDecimal(data[4]));
        // From index 5, the line holds the IDs of the privates this general commands.
        // Each id is a single word, so i++ moves one position at a time. Every id
        // is looked up in soldiersById and added to the general's list.
        for (var i = 5; i < data.Length; i++)
        {
            var privateId = data[i];
            lieutenantGeneral.AddPrivate(soldiersById[privateId]);
        }
        return lieutenantGeneral;
    }

    private static ISoldier CreatePrivateSoldier(string[] data) =>
        new PrivateSoldier(data[1], data[2], data[3], ParseDecimal(data[4]));

    private static ISoldier CreateEngineer(string[] data)
    {
        var engineer = new Engineer(data[1], data[2], data[3], ParseDecimal(data[4]),
            ParseCorps(data[5]));
        // From index 6, the line holds repairs as pairs: <partName> <hoursWorked>.
        // i += 2 jumps from one pair to the next; i < data.Length - 1 guarantees
        // that data[i + 1] (the hours) exists, so a dangling part name is ignored.

        for (int i = 6; i < data.Length - 1; i += 2)
        {
            var repair = new Repair(data[i], ParseInt(data[i + 1]));
            engineer.AddRepair(repair);
        }
        return engineer;
    }

    private static ISoldier CreateSpy(string[] data) => new Spy(data[1], data[2], data[3], ParseInt(data[4]));

    private static decimal ParseDecimal(string value) =>
        decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : throw new ArgumentException("Invalid decimal: " + value);

    private static int ParseInt(string value) =>
        int.TryParse(value, out var result) ? result : throw new ArgumentException("Invalid number: " + value);

    private static SoldierCorps ParseCorps(string value) =>
        Enum.TryParse(value, out SoldierCorps result) && Enum.IsDefined(result)
            ? result
            : throw new InvalidCorpsException(value);

    private sealed class InvalidCorpsException : Exception
    {
        public InvalidCorpsException(string value) : base("Invalid corps: " + value)
        {
        }
    }

    private static string ReadRequiredLine()
    {
        var line = Console.ReadLine();
        return string.IsNullOrWhiteSpace(line)
            ? throw new ArgumentException("Input cannot be null, empty or whitespace.")
            : line;
    }
}
