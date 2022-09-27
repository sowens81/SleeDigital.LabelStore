using System;
namespace LabelStore.Shipping.Api.Exceptions
{
    [Serializable]
    public class MissingIdException : ArgumentException
    {
        public MissingIdException(string message, string parameter) : base(message, parameter)
        {
        }
    }
}

