namespace Tippytappy.Nodes;

public class Document : ITiptapNode
{
    public string Name => "doc";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        // Empty node, no need to render anything
        next();
    }
}