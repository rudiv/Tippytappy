# Tippytappy

This tiny lil library just renders Tiptap's JSON to a HTML string.

## Install

Install `R.Tippytappy` from NuGet.

## Usage

```csharp
var config = new TippytappyConfiguration().AddStarterKit();
var tippytapppy = new Tippytappy(config);
var html = tippytapppy.Render(json);
```

With dependency injection:

```csharp
builder.Services.AddSingleton(new TippytappyConfiguration().AddStarterKit().AddExtension<Underline>());
builder.Services.AddSingleton<Tippytappy.Tippytappy>();
```