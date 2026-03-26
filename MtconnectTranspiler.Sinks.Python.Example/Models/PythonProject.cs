using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    [ScribanTemplate("Python.PyProject.scriban")]
    public class PythonProject : PythonType, IFileSource
    {
        public string Filename { get => "pyproject.toml"; set { } }
        public PythonProject(XmiDocument doc, UmlModel source) : base(doc, source) { }
    }
}
