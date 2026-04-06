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

# Install from TestPyPI

When installing a project from TestPyPI, its database is separate from live PyPI. This might cause the installation to fail because the package's dependencies likely do not exist on the test server (TestPyPI).

Use `--extra-index-url https://pypi.org/simple/` to direct pip to use the normal PyPI server for dependencies.

```bash
pip install -i https://test.pypi.org/simple/ pymtconnect --extra-index-url https://pypi.org/simple/
```

Use `pymtconnect==<version>` to specify a version of pymtconnect to install

```bash
 pip install -i https://test.pypi.org/simple/ pymtconnect==<version> --extra-index-url https://pypi.org/simple/
```



