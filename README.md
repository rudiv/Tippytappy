# Tippytappy

This tiny lil library just renders Tiptap's JSON to a HTML string.

## Usage

```csharp
var config = new TippytappyConfiguration().AddStarterKit();
var tippytapppy = new Tippytappy(config);
var html = tippytapppy.Render(json);
```
