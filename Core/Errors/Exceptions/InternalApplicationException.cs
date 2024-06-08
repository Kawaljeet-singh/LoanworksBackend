using System.Runtime.Serialization;

namespace LoanworksBackend.Core.Errors;

[Serializable]
internal class InternalApplicationException : Exception
{
    public InternalApplicationException()
    {
    }

    public InternalApplicationException(string? message) : base(message)
    {
    }

    public InternalApplicationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InternalApplicationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}