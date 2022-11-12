using Azure;

namespace xms_error_responses;

internal static class ErrorResponseExceptionFactory
{
    internal static RequestFailedException<T> Create<T>(T value, Response response) => new(value, response);
}
