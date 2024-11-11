namespace API.Errors
{
    public class APIResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public APIResponse(int statusCode, string message = null, object data = null)
        {
            StatusCode = statusCode;
            Message = message ?? defaultMessageForStatusCode(statusCode);
            Data = data;
        }

        private string? defaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger. Anger leads to hate. Hate leads to career change",
                403 => "Forbidden, you do not have permission",
                408 => "Request timeout, please try again",
                409 => "Conflict, there is a conflict with the current state",
                422 => "Unprocessable entity, the request was well-formed but unable to be followed",
                429 => "Too many requests, you have hit the rate limit",
                _ => null
            };
        }

    }
}