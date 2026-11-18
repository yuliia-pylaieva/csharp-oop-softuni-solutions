using System.Text;

namespace MilitaryElite.Models;

internal static class Helpers
{
    internal static void PrepareMultilineOutput(StringBuilder sb, string label, IEnumerable<object> objects)
    {
        sb.Append(label);
        foreach (var item in objects)
        {
            sb.AppendLine();
            sb.Append("  ");
            sb.Append(item);
        }
    }
}