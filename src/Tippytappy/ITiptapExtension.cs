namespace Tippytappy;

public interface ITiptapExtension
{
    TiptapExtensionType Type { get; }
    
    string Name { get; }

    void Render(TiptapJsonNode node, RenderContext context, Action next);
}

public enum TiptapExtensionType {
    Node,
    Mark
}