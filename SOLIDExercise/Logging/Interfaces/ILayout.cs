using Logging.Enums;

namespace Logging.Interfaces;

public interface ILayout
{
    // Single Responsibility - yes
    // Open/Closed - 80% ( open - control the time display format)
    //Interface segregation - yes
    string Format(ILogMessage logMessage);
}