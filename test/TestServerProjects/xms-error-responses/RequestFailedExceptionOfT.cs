using Azure;

namespace xms_error_responses;

public class RequestFailedException<T> : RequestFailedException
{
    public T Model { get; }

    public RequestFailedException(T value, Response response)
        : base(response.Status, $"Error reponse {typeof(T).Name}")
    {
        Model = value;
    }
}
