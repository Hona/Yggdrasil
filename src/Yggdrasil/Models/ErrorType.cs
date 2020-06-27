using System.Runtime.Serialization;

namespace Yggdrasil.NET.Models
{
    public enum ErrorType
    {
        Unknown = 0,
        [EnumMember(Value = "Method Not Allowed")]
        MethodNotAllowed,
        [EnumMember(Value = "Not Found")]
        NotFound,
        [EnumMember(Value = "ForbiddenOperationException")]
        ForbiddenOperationException,
        [EnumMember(Value = "IllegalArgumentException")]
        IllegalArgumentException,
        [EnumMember(Value = "Unsupported Media Type")]
        UnsupportedMediaType
    }
}