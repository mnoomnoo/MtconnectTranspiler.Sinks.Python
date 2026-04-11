using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Generates a <c>streaming_example.py</c> file that opens a persistent
    /// HTTP connection to /sample?interval=N on an MTConnect agent, receives
    /// observation batches as the agent pushes them, fills
    /// <see cref="StreamsHeaderClass"/> and <see cref="ObservationGeneralization"/>
    /// instances, and prints a live ticker.
    /// </summary>
    [ScribanTemplate("Python.StreamingExample.scriban")]
    public class PythonStreamingExample : PythonType, IFileSource
    {
        /// <inheritdoc />
        public string Filename { get => "streaming_example.py"; set { } }

        private readonly List<PythonPackage> _packages;
        /// <summary>Top-level packages exposed to the Scriban template as <c>source.packages</c>.</summary>
        public IEnumerable<PythonPackage> Packages => _packages;

        public PythonStreamingExample(XmiDocument doc, UmlModel source, IEnumerable<PythonPackage> packages)
            : base(doc, source)
        {
            _packages = packages.ToList();
        }
    }
}
