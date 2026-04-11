using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Generates a <c>current_example.py</c> file that fetches /current from an
    /// MTConnect agent, fills <see cref="StreamsHeaderClass"/>, <see cref="EventClass"/>,
    /// and <see cref="ConditionClass"/> instances, and prints them.
    /// </summary>
    [ScribanTemplate("Python.CurrentExample.scriban")]
    public class PythonCurrentExample : PythonType, IFileSource
    {
        /// <inheritdoc />
        public string Filename { get => "current_example.py"; set { } }

        private readonly List<PythonPackage> _packages;
        /// <summary>Top-level packages exposed to the Scriban template as <c>source.packages</c>.</summary>
        public IEnumerable<PythonPackage> Packages => _packages;

        public PythonCurrentExample(XmiDocument doc, UmlModel source, IEnumerable<PythonPackage> packages)
            : base(doc, source)
        {
            _packages = packages.ToList();
        }
    }
}
