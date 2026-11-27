using System.Globalization;
using Logging.Enums;
using Logging.Interfaces;

namespace Logging.Core;

// Reads the appenders and the log messages from the console
public class CommandInterpreter
{
    private const string EndCommand = "END";

    private readonly IAppenderBuilder _appenderBuilder;

    public CommandInterpreter(IAppenderBuilder appenderBuilder)
    {
        ArgumentNullException.ThrowIfNull(appenderBuilder);
        _appenderBuilder = appenderBuilder;
    }

    public IAppender[] ReadAppenders()
    {
        ReadRequiredLine(out string countInput);
        ParseInt(countInput, out int count);
        if (count < 0)
            throw new FormatException($"Invalid integer: {countInput}");

        IAppender[] appenders = new IAppender[count];
        for (int i = 0; i < count; i++)
        {
            ReadRequiredLine(out string appenderInput);
            appenders[i] = _appenderBuilder.Build(appenderInput.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }

        return appenders;
    }

    public void ReadLogMessages(ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(logger);

        ReadRequiredLine(out string logMessageInput);
        while (logMessageInput != EndCommand)
        {
            string[] logMessage = logMessageInput.Split('|');
            if (logMessage.Length != 3)
                throw new FormatException($"Invalid log message: {logMessageInput}");

            ParseReportLevel(logMessage[0], out ReportLevel reportLevel);
            ParseDateTime(logMessage[1], out DateTime dateTime);

            logger.Log(reportLevel, logMessage[2], dateTime);

            ReadRequiredLine(out logMessageInput);
        }
    }

    private static void ReadRequiredLine(out string line)
    {
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Invalid input");

        line = input;
    }

    private static void ParseInt(string input, out int result)
    {
        if (!int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
            throw new FormatException($"Invalid integer: {input}");
    }

    private static void ParseReportLevel(string input, out ReportLevel result)
    {
        if (!Enum.TryParse(input, ignoreCase: true, out result) || !Enum.IsDefined(result))
            throw new FormatException($"Invalid report level: {input}");
    }

    private static void ParseDateTime(string input, out DateTime result)
    {
        if (!DateTime.TryParse(input, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            throw new FormatException($"Invalid date: {input}");
    }
}
