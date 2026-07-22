using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Generates a <c>probe_example.py</c> file that probes an MTConnect agent,
    /// fully fills <see cref="HeaderClass"/> and <see cref="DeviceClass"/> via
    /// <c>from_dict()</c>, and walks the complete raw device/component/data-item
    /// JSON tree.
    /// </summary>
    [ScribanTemplate("Python.ProbeDeepExample.scriban")]
    public class PythonProbeDeepExample : PythonType, IFileSource
    {
        /// <inheritdoc />
        public string Filename { get => "probe_example.py"; set { } }

        private readonly List<PythonPackage> _packages;
        /// <summary>Top-level packages exposed to the Scriban template as <c>source.packages</c>.</summary>
        public IEnumerable<PythonPackage> Packages => _packages;

        public PythonProbeDeepExample(XmiDocument doc, UmlModel source, IEnumerable<PythonPackage> packages)
            : base(doc, source)
        {
            _packages = packages.ToList();
        }
    }
}
