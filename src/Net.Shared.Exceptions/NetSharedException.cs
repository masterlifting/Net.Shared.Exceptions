namespace Net.Shared.Exceptions;

public abstract class NetSharedException : Exception
{
    private readonly string _message;

    protected NetSharedException(string message)
    {
        _message = message;
    }
    protected NetSharedException(Exception exception)
    {
        _message = exception.InnerException?.Message ?? exception.Message;
    }

    public override string Message => _message;
}