using NCI.OCPL.Api.Common;

namespace NCI.OCPL.Api.Glossary
{
    /// <summary>
    /// Notes a media item, type determined by the Type property.
    /// </summary>
    [InterfaceJsonConverterShim(typeof(InterfaceJsonConverter<IMedia>))]
    public interface IMedia
    {
        /// <summary>
        /// type of media to be used
        /// </summary>
        MediaType Type { get; }
    }
}