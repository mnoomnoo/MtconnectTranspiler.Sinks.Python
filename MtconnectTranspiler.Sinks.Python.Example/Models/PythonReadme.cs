using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    [ScribanTemplate("Python.Readme.scriban")]
    public class PythonReadme : PythonType, IFileSource
    {
        public string Filename { get => "README.md"; set { } }
        public PythonReadme(XmiDocument doc, UmlModel source) : base(doc, source) { }
    }
}
