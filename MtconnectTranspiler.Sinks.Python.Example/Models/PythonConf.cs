using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    [ScribanTemplate("Python.Conf.scriban")]
    public class PythonConf : PythonType, IFileSource
    {
        public string Filename { get => "conf.py"; set { } }
        public PythonConf(XmiDocument doc, UmlModel source) : base(doc, source) { }
    }
}
