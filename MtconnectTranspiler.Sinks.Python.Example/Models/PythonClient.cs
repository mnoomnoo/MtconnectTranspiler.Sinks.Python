using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Generates an <c>mtconnect_client.py</c> file that provides reusable
    /// <c>probe</c>, <c>current</c>, and <c>sample</c> helpers for querying an
    /// MTConnect agent.  The module can be imported by any project that ships
    /// alongside the generated MTConnect Python package.
    /// </summary>
    [ScribanTemplate("Python.Client.scriban")]
    public class PythonClient : PythonType, IFileSource
    {
        /// <inheritdoc />
        public string Filename { get => "mtconnect_client.py"; set { } }

        private readonly List<PythonPackage> _packages;
        /// <summary>Top-level packages exposed to the Scriban template as <c>source.packages</c>.</summary>
        public IEnumerable<PythonPackage> Packages => _packages;

        public PythonClient(XmiDocument doc, UmlModel source, IEnumerable<PythonPackage> packages)
            : base(doc, source)
        {
            _packages = packages.ToList();
        }
    }
}
