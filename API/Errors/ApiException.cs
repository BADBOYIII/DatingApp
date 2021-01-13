namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string details = null) 
        {
            StatusCode = statusCode;
            Messages = message;
            Details = details;
        }

        public int StatusCode { get; set; }

        public string Messages { get; set; }

        public string Details { get; set; }
    }
}
