namespace Tippytappy.Marks;

public class Strike : ITiptapMark
{
    public string Name => "strike";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<s>");
        next();
        context.Append("</s>");
    }
}