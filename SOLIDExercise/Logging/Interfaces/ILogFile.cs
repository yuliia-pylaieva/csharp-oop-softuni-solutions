namespace Logging.Interfaces;

public interface ILogFile
{
    // sum of the ASCII codes of all letters (a-z, A-Z) written so far
    int Size { get; }

    void Write(string formattedLogMessage);
}
