namespace Bumbo.Models
{
    public class ErrorViewModel
    {
        public int ErrorCode { get; set; }
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorMessage { get; set; }
    }
}