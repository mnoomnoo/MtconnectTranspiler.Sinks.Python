using MtconnectTranspiler.CodeGenerators.ScribanTemplates;

namespace MtconnectTranspiler.Sinks.Python.Example.Models
{
    /// <summary>
    /// Stub model used to generate the static <c>base.py</c> file which
    /// contains <c>MtconnectBase</c> — the root base class for all generated types.
    /// </summary>
    [ScribanTemplate("Python.Base.scriban")]
    public class PythonBase : IFileSource
    {
        /// <inheritdoc />
        public string Filename { get; set; } = "base.py";
    }
}
