using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.Python.Models;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Model for the top-level <c>pymtconnect/__init__.py</c>, exporting the most
    /// commonly used classes and enums so <c>from pymtconnect import Device</c> works
    /// without deep-path imports.
    /// </summary>
    [ScribanTemplate("Python.Init.scriban")]
    public class PythonInit : IFileSource
    {
        /// <inheritdoc />
        public string Filename { get; set; } = "__init__.py";

        /// <summary>
        /// Curated class exports. Several SysML packages (Glossary, MTConnectTerms, …)
        /// define classes with the same name, so each export names the namespace whose
        /// definition is the canonical one.
        /// </summary>
        private static readonly (string Name, string PreferredNamespace)[] _classExports = new[]
        {
            ("Device", "DeviceInformationModel"),
            ("Component", "Components"),
            ("Composition", "Compositions"),
            ("DataItem", "DataItems"),
            ("Description", "Components"),
            ("Interface", "InterfaceInteractionModel"),
        };

        private static readonly string[] _enumExports = new[]
        {
            "CategoryEnum", "EventEnum", "SampleEnum", "ConditionEnum",
            "InterfaceEventEnum", "DataItemTypeEnum", "DataItemSubTypeEnum",
            "CompositionTypeEnum", "UnitEnum", "NativeUnitEnum",
        };

        public List<PythonClass> Classes { get; } = new List<PythonClass>();
        public List<PythonEnum> Enums { get; } = new List<PythonEnum>();

        public PythonInit(IEnumerable<PythonClass> allClasses, IEnumerable<PythonEnum> allEnums)
        {
            foreach (var (name, preferredNamespace) in _classExports)
            {
                var candidates = allClasses.Where(c => c.CleanName == name).ToList();
                var match = candidates.FirstOrDefault(c => c.Namespace?.EndsWith(preferredNamespace) == true)
                    ?? candidates.FirstOrDefault();
                if (match != null)
                    Classes.Add(match);
            }
            foreach (var name in _enumExports)
            {
                var match = allEnums.FirstOrDefault(e => e.Name == name);
                if (match != null)
                    Enums.Add(match);
            }
        }
    }
}
