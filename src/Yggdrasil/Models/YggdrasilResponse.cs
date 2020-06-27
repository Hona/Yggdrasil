namespace Yggdrasil.Models
{
    public class YggdrasilResponse<T>
    {
        public bool Success { get; set; }
        public ErrorResponse ErrorResponse { get; set; }
        public T Response { get; set; }
    }
}