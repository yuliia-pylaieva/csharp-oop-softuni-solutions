using Logging.Enums;

namespace Logging.Interfaces;

//Single Responsibility - yes 
//Interface Segregation - yes

public interface IAppender
{
    //ILayout Layout { get; }
    
    int AppendedMessageCount { get; }
    
    void Append(ILogMessage logMessage);

}
