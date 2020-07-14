namespace WebApplication.Application
{
    public abstract class Response
    {
        public Respose(string requestId)
        {
            RequestId = requestId;
        }

        public Request Request { get; set; }

        public string RequestId { get; }
    }
}