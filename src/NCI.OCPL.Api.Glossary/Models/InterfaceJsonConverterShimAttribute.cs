using System;
using System.Text.Json.Serialization;

namespace NCI.OCPL.Api.Common
{

    /// <summary>
    /// Attribute for assigning converters to interfaces.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Property, AllowMultiple = false)]
    public class InterfaceJsonConverterShimAttribute : JsonConverterAttribute
    {
        public InterfaceJsonConverterShimAttribute(Type converterType)
            : base(converterType)
        {
        }
    }
}