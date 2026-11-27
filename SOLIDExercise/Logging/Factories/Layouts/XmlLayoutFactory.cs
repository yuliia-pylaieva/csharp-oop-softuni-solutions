using Logging.Interfaces;
using Logging.Interfaces.Factories;
using Logging.Layouts;

namespace Logging.Factories.Layouts;

public class XmlLayoutFactory : ILayoutFactory
{
    private readonly string _dateFormat;

    public XmlLayoutFactory(string dateFormat = LayoutFormats.DefaultDateFormat)
    {
        _dateFormat = dateFormat;
    }

    public ILayout CreateLayout() => new XmlLayout(_dateFormat);
}
