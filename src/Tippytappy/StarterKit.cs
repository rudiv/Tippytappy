using Tippytappy.Marks;
using Tippytappy.Nodes;

namespace Tippytappy;

public static class StarterKit
{
    public static TippytappyConfiguration AddStarterKit(this TippytappyConfiguration config)
    {
        config.AddExtension<Blockquote>();
        config.AddExtension<BulletList>();
        config.AddExtension<CodeBlock>();
        config.AddExtension<Document>();
        config.AddExtension<HardBreak>();
        config.AddExtension<Heading>();
        config.AddExtension<HorizontalRule>();
        config.AddExtension<ListItem>();
        config.AddExtension<OrderedList>();
        config.AddExtension<Paragraph>();
        config.AddExtension<Text>();
        
        config.AddExtension<Bold>();
        config.AddExtension<Code>();
        config.AddExtension<Italic>();
        config.AddExtension<Strike>();
        return config;
    }
}