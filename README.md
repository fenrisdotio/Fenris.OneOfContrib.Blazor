# OneOf.Extensions.Blazor

A collection of Blazor components for working with [OneOf](https://github.com/mcintyre321/OneOf) types in your Blazor project.

## 🤔 Why?

I was working on a project where I needed to render different components based on the value of a `OneOf`.
I couldn't get the `OneOf.Switch()` method to work in Blazor, and writing `switch` statements over and over again
was annoying and looked messy.

Instead I made a component library, which is actually just a switch statement in disguise,
and found it made my Blazor components much more readable and in general nicer to work with.

## ⭐ Features

- Blazor components for `OneOf` types with up to **8** type parameters.
- Blazor components for types that inherit from `OneOfBase`, also with up to **8** type parameters.

That's, that's it. It's a pretty simple library 😁

## 💿 Installation

Install the [OneOf.Extensions.Blazor](https://www.nuget.org/packages/OneOf.Extensions.Blazor/) NuGet package.

```bash
dotnet add package OneOf.Extensions.Blazor
```

## 🚀 Usage

See the [Examples](examples/OneOf.Extensions.Blazor.Examples/Pages/Index.razor) project for a full, simple example.

Let's make a small example where we have to deal with a `OneOf<string, int>`.

First, add the using either to your `_Imports.razor` file, or directly in your specific pages/components:
```csharp
@using OneOf.Extensions.Blazor
```

Then use the component in your blazor pages or components 

```csharp
<OneOfSwitch2 Value="myOneOf">
    <T0Template>
        <p>It's a string and the value is @context!</p>
    </T0Template>
    <T1Template>
        <p>It's an int and the value is @context!</p>
    </T1Template>
</OneOfSwitch2>

@code {
    private OneOf<string, int> myOneOf = "Hello World!";
}
```

If you are using a `OneOfBase` type, you need to use the `<OneOfBaseSwitch2>` component instead. Everything else is identical.

If your union contains more than two types, you need to use the `<OneOfSwitchN>` or `<OneOfBaseSwitchN>` components, where `N` is the number of types in your union. E.g. `<OneOfSwitch5>`

## 🐛 Bugs, feature requests, and contributions

If you find a bug or have a feature request, please open an issue. 

Pull requests are also welcome 😊
