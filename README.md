# MtconnectTranspiler.Sinks.Python

This is an implementation of the [MtconnectTranspiler](https://github.com/mtconnect/MtconnectTranspiler) that generates a complete Python package — classes, enums, and packages — from the [MTConnect](https://www.mtconnect.org/) SysML/UML model.

## Requirements

- .NET 8.0 SDK

## Build & run

Build the example project:

```bash
dotnet build MtconnectTranspiler.Sinks.Python.Example/MtconnectTranspiler.Sinks.Python.Example.csproj
```

Run it, passing the output directory as the first argument and, optionally, a path to a local model file:

```bash
dotnet run --project MtconnectTranspiler.Sinks.Python.Example <OutputPath> [--ModelPath <path>]
```

If `--ModelPath` is omitted, the latest model is downloaded from GitHub. These same settings — `OutputPath` and `ModelPath` — can also be set in `appsettings.json` / `appsettings.Development.json` instead of passing them on the command line.

When running from an IDE (e.g. pressing F5 in Visual Studio), edit the arguments in `MtconnectTranspiler.Sinks.Python.Example/Properties/launchSettings.json` instead, for example:

```json
"commandLineArgs": "\"$(SolutionDir)my_output\" \"/path/to/my/model/MTConnectSysMLModel.xml\""
```

## Output

The generator writes a complete Python package to the output directory. See the generated package's own `README.md` for details on the package layout and how to use the generated classes (`from_dict`/`to_dict`/`to_json` serialization, the `mtconnect_client` helpers for querying a live agent, etc.).

The generated package is published on PyPI as [pymtconnect](https://pypi.org/project/pymtconnect).

## License

Apache-2.0
