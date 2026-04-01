# MtconnectTranspiler.Sinks.Python

## What this project does
A C# (.NET 8.0) code generator that reads the MTConnect SysML/UML model (XMI format) and outputs a complete Python package — classes, enums, packages, and supporting files.

## Tech stack
- **C# / .NET 8.0** — transpiler application
- **Scriban** — template engine driving all Python code generation
- **MtconnectTranspiler** (v2.4.0) — core framework that parses the SysML model

## Build & run
```bash
# Build
dotnet build MtconnectTranspiler.Sinks.Python.Example/MtconnectTranspiler.Sinks.Python.Example.csproj

# Run
dotnet run --project MtconnectTranspiler.Sinks.Python.Example <OutputPath> [--ModelPath <path>]
```

Configuration lives in `appsettings.json` / `appsettings.Development.json`:
- `OutputPath` — directory where generated Python files are written
- `ModelPath` — path to XMI model file (omit to download the latest from GitHub)

## Key directories
```
MtconnectTranspiler.Sinks.Python/          # Python sink contracts (MTCEnum base class)
MtconnectTranspiler.Sinks.Python.Example/  # Main C# executable
  Models/      # C# models: PythonClass, PythonEnum, PythonPackage, PythonClient, etc.
  Templates/   # Scriban templates that emit Python source files
  Program.cs   # Entry point — DI setup, config loading, orchestration
  Transpiler.cs # Core ISink implementation — walks the model and writes files
```

## MTConnect model reference
The MTConnect SysML model is the source of truth for the specification.

If a query requires understanding a specific type, element, or relationship in the spec, the model is at:
`https://github.com/mtconnect/mtconnect_sysml_model/blob/master/MTConnectSysMLModel.xml`

**The file is ~15 MB — never fetch it in full.** The model is hierarchical; fetch only the specific element or subtree needed. A child element can be understood in isolation with its immediate parent context.
