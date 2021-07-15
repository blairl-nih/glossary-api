using NCI.OCPL.Api.Common;

namespace NCI.OCPL.Api.Glossary
{
    /// <summary>
    /// Describes a GlossaryTerm's related resource.
    /// </summary>
    public interface IRelatedResource
    {
        /// <summary>
        /// Notes the related resource type.
        /// </summary>
        RelatedResourceType Type { get; set; }

        /// <summary>
        /// Short text description or name of the resource.
        /// </summary>
        string Text { get; set; }
    }
}