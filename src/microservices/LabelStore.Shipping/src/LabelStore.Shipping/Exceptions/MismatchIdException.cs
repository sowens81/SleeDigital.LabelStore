using System;

namespace LabelStore.Shipping.Api.Exceptions
{
    {
    [Serializable]
    public class MismatchIdException : ArgumentException
    {
        public MismatchIdException(string message, string parameter) : base(message, parameter)
        { }
    }
}
}

