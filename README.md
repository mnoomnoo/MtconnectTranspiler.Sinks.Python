# MtconnectTranspiler.Sinks.Python
This is an implementation of the [MtconnectTranspiler](https://github.com/mtconnect/MtconnectTranspiler) with the purpose of providing tools to generate Python files from the object-oriented model.

# Build and upload Python package

## Prerequisites
- `build`: `pip install build`
- `twine`: `pip install twine`

## Build the wheel

```bash
python -m build
```

Output is written to `dist/`.

## Upload to PyPI

Upload to TestPyPI:
```bash
python -m twine upload --repository testpypi dist/*
```

Upload to PyPI:
```bash
python -m twine upload dist/*
```