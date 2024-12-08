using System.Text;

namespace Tippytappy;

public class RenderContext(Tippytappy tippytappy)
{
    private readonly StringBuilder builder = new();

    public void Append(string text)
    {
        builder.Append(text);
    }
    
    public void AppendLine(string text)
    {
        builder.AppendLine(text);
    }

    public ITiptapExtension ExtensionFor(string type)
    {
        return tippytappy.ExtensionFor(type);
    }

    public override string ToString()
    {
        return builder.ToString();
    }
}