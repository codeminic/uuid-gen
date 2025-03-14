![Publish](https://github.com/codeminic/uuid-gen/actions/workflows/publish.yml/badge.svg)
[![NuGet version](https://img.shields.io/nuget/v/codeminic.UuidGen.svg)](https://www.nuget.org/packages/codeminic.UuidGen/)

This is a dead simple .NET tool for generating UUIDs using the new UUID version 7.

## Installation

To install the tool globally, use the following command:

```sh
dotnet tool install -g codeminic.UuidGen
```

## Usage

To generate a new UUID, use the following command:

```sh
gg
```

**Note:** The gg command may conflict with `git gui` on some shells, such as zsh, which uses gg as 
a git gui alias. 
If you encounter this issue, you can either change the alias in your shell configuration or use the 
full command path to run the tool.