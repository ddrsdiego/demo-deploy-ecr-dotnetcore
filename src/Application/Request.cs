namespace WebApplication.Application
{
    using System.Diagnostics;

    public abstract class Request
    {
        public abstract class Request
        {
            protected Request(string requestId) => RequestId = requestId;

            protected Request()
                : this(Guid.NewGuid().ToString())
            {
            }

            public string RequestId { get; }
            public DateTime RequestedAt { get; } = DateTime.Now;
            public abstract Response Response { get; }
        }
    }
}