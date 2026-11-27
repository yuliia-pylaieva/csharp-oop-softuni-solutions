using Logging.Enums;
using Logging.Interfaces;
using Logging.Interfaces.Factories;

namespace Logging.Builders;

public class AppenderBuilder : IAppenderBuilder
{
    private readonly IReadOnlyDictionary<string, IAppenderFactory> _appenderFactories;
    private readonly IReadOnlyDictionary<string, ILayoutFactory> _layoutFactories;

    public AppenderBuilder(
        IReadOnlyDictionary<string, IAppenderFactory> appenderFactories,
        IReadOnlyDictionary<string, ILayoutFactory> layoutFactories)
    {
        ArgumentNullException.ThrowIfNull(appenderFactories);
        ArgumentNullException.ThrowIfNull(layoutFactories);
        _appenderFactories = appenderFactories;
        _layoutFactories = layoutFactories;
    }

    public IAppender Build(string[] data)
    {
        if (data.Length < 2 || data.Length > 3)
            throw new FormatException("Invalid appender definition");

        if (!_appenderFactories.TryGetValue(data[0], out IAppenderFactory? appenderFactory))
            throw new ArgumentException($"Invalid appender type: {data[0]}");

        if (!_layoutFactories.TryGetValue(data[1], out ILayoutFactory? layoutFactory))
            throw new ArgumentException($"Invalid layout type: {data[1]}");

        Func<ILogMessage, bool>? filter = null;
        if (data.Length == 3)
        {
            if (!Enum.TryParse(data[2], ignoreCase: true, out ReportLevel reportLevelThreshold)
                || !Enum.IsDefined(reportLevelThreshold))
                throw new FormatException($"Invalid report level: {data[2]}");

            filter = (lm) => lm.ReportLevel >= reportLevelThreshold;
        }

        return appenderFactory.CreateAppender(layoutFactory.CreateLayout(), filter);
    }
}
