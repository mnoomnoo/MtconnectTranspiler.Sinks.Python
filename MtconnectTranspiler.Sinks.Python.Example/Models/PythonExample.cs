using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Generates an <c>example.py</c> file that demonstrates how to consume
    /// the generated MTConnect Python package.
    /// </summary>
    [ScribanTemplate("Python.Example.scriban")]
    public class PythonExample : PythonType, IFileSource
    {
        /// <inheritdoc />
        public string Filename { get => "example.py"; set { } }

        private readonly List<PythonPackage> _packages;
        /// <summary>Top-level packages exposed to the Scriban template as <c>source.packages</c>.</summary>
        public IEnumerable<PythonPackage> Packages => _packages;

        public PythonExample(XmiDocument doc, UmlModel source, IEnumerable<PythonPackage> packages)
            : base(doc, source)
        {
            _packages = packages.ToList();
        }
    }
}
