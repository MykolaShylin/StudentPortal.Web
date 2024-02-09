namespace StudentPortal.Web.Models
{
    public class ServiceResponce<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string ModelErrorField { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
