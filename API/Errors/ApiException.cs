namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int staturCode, string message = null, string details = null)
        {
            StaturCode = staturCode;
            Message = message;
            Details = details;
        }

        public int StaturCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}