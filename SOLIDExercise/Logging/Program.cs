using Logging.Appenders;
using Logging.Builders;
using Logging.Core;
using Logging.Factories.Appenders;
using Logging.Factories.Layouts;
using Logging.Interfaces;
using Logging.Interfaces.Factories;
using Logging.Layouts;
using Logging.Loggers;

public static class Program
{
    private const string DefaultLogFilePath = "logs.txt"; // should come from a config file

    private static void Main(string[] args)
    {
        try
        {
            // composition root
            var appenderFactories = new Dictionary<string, IAppenderFactory>
            {
                [nameof(ConsoleAppender)] = new ConsoleAppenderFactory(),
                [nameof(FileAppender)] = new FileAppenderFactory(DefaultLogFilePath),
            };
            var layoutFactories = new Dictionary<string, ILayoutFactory>
            {
                [nameof(SimpleLayout)] = new SimpleLayoutFactory(),
                [nameof(XmlLayout)] = new XmlLayoutFactory(),
            };

            var interpreter = new CommandInterpreter(new AppenderBuilder(appenderFactories, layoutFactories));

            ILogger logger = new Logger(interpreter.ReadAppenders());
            interpreter.ReadLogMessages(logger);

            Console.WriteLine("Logger info");
            foreach (IAppender appender in logger.Appenders)
                Console.WriteLine(appender);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
