namespace Yggdrasil.Models
{
    public enum ErrorType
    {
        Unknown = 0,
        MethodNotAllowed,
        NotFound,
        ForbiddenOperationException,
        IllegalArgumentException,
        UnsupportedMediaType
    }
}