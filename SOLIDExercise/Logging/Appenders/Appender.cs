using Logging.Enums;
using Logging.Interfaces;

namespace Logging.Appenders;

public abstract class Appender: IAppender
{
    private readonly ILayout _layout;
    private readonly Func<ILogMessage, bool>? _filter;

    protected Appender(ILayout layout,  Func<ILogMessage, bool>? filter = null)
    {
        ArgumentNullException.ThrowIfNull(layout);
        this._layout = layout;
        this._filter =  filter;
    }

    public int AppendedMessageCount {get; private set;}

    public void Append(ILogMessage logMessage)
    {
        //1. Check report level
        // - delegate
        
        if (this._filter is not null && !this._filter(logMessage))  return;
        
        //2. format the log message - use layout
        string formattedLogMessage = this._layout.Format(logMessage);
        
        //3. Append the message
        this.Append(formattedLogMessage);
        this.AppendedMessageCount++;
    }
    protected abstract void Append(string formattedLogMessage);

    public override string ToString()
        => $"Appender type: {this.GetType().Name}, Layout type: {this._layout.GetType().Name}, Messages appended: {this.AppendedMessageCount}";
}
