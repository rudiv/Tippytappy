namespace Tippytappy.Marks;

public class Underline : ITiptapMark
{
    public string Name => "underline";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<u>");
        next();
        context.Append("</u>");
    }
}