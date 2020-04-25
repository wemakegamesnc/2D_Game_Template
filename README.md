# WMG 2D Game Template
This repo is a template from where to start all of the games we are working on. Inside this you will find the following:

 - A MonoGame starting project
 - On top of MonoGame, you will see some simple ECS systems/components to draw a static image on screen
 - A list of tools and packages that we are currently using for development of our games.

*NOTE: this repo will have different versions as we make progress with our games and find new things to share to the rest of the community!* 

## Requirements

This game is being developed using MonoGame ([MonoGame.Framework.DesktopGL.Core@3.8.0.13](https://www.nuget.org/packages/MonoGame.Framework.DesktopGL.Core/)) with [.NetCore 3.1](https://dotnet.microsoft.com/download). 

As an IDE we use VS Code rather than Visual Studio, for a smooth development experience we have installed the following extensions and modified these settings:

* Install [.Net Core Sdk 3.1](https://dotnet.microsoft.com/download)
* Install [MonoGame Asset Pipeline](https://community.monogame.net/t/monogame-3-7-1-release/11173)
* [C# Language Support](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
    - This extension is powered by Omnisharp which can handle formatting by providing an `omnisharp.json` file at the root of the repo, which is exactly how I am using it!.
    - To configure the omnisharp settings check it out [here](https://github.com/OmniSharp/omnisharp-roslyn/wiki/Configuration-Options)
    - In VSCode setting set the following if you want formatting on save
        - `Preferences` -> `Settings` -> `Csharp.format.enable` set it to `true`
        - `Preferences` -> `Settings` -> `Editor.formatOnSave` set it to `true`
* [Git Lens](https://marketplace.visualstudio.com/items?itemName=eamodio.gitlens) - neat tool for git things :)
* [Todo Tree](https://marketplace.visualstudio.com/items?itemName=Gruntfuggly.todo-tree) - allows for a visualization of all todos in the project
* [Code Spell Checker](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker)
    - Helps identify misspelled code for faster debugging

Currently our games are being built using an [Entity Component System (ECS)](https://en.wikipedia.org/wiki/Entity_component_system). We are taking advantage of the awesome ECS package [defaultECS @ v0.14.2](https://github.com/Doraku/DefaultEcs) by [Doraku](https://github.com/Doraku)!

## Todo

- [ ] Make this repo into a .NetCore Template
- [ ] Provide a better starting template for ECS
- [ ] Create release tags for different versions 