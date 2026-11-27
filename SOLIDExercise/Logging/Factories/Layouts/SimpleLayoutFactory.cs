using Logging.Interfaces;
using Logging.Interfaces.Factories;
using Logging.Layouts;

namespace Logging.Factories.Layouts;

public class SimpleLayoutFactory : ILayoutFactory
{
    private readonly string _dateFormat;

    public SimpleLayoutFactory(string dateFormat = LayoutFormats.DefaultDateFormat)
    {
        _dateFormat = dateFormat;
    }

    public ILayout CreateLayout() => new SimpleLayout(_dateFormat);
}
