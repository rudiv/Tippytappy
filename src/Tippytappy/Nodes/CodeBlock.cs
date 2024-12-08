namespace Tippytappy.Nodes;

public class CodeBlock : ITiptapNode
{
    public string Name => "codeBlock";
    
    public void Render(TiptapJsonNode node, RenderContext context, Action next)
    {
        context.Append("<pre><code>");
        next();
        context.AppendLine("</code></pre>");
    }
}