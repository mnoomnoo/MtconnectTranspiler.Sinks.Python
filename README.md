# MtconnectTranspiler.Sinks.Python
This is an implementation of the [MtconnectTranspiler](https://github.com/mtconnect/MtconnectTranspiler) with the purpose of providing tools to generate Python files from the object-oriented model.

# Program arguments

In `MtconnectTranspiler.Sinks.Python.Example/Properties/launchSettings.json` you can edit program arguments.

First argument is the directory to place the generated output. The second directory is an optional argument

Example: `"commandLineArgs":
        "\"$(SolutionDir)my_output\" \"/path/to/my/model/MTConnectSysMLModel.xml\""`

# Build and upload Python package

## Prerequisites
- `build`: `pip install build`
- `twine`: `pip install twine`

## Build the wheel

```bash
python -m build
```

Output is written to `dist/`.

## Upload to PyPI or TestPyPI

https://test.pypi.org/help/#apitoken shows how to setup PyPI API tokens for uploading

### Upload to TestPyPI:

```bash
python -m twine upload --repository testpypi dist/*
```

### Upload to PyPI:
```bash
python -m twine upload dist/*
```