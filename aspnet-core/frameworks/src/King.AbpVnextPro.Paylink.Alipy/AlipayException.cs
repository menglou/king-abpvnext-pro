using System;

namespace King.AbpVnextPro.Paylink.Alipy
{
    public class AlipayException : Exception
    {
        public AlipayException()
        {
        }

        public AlipayException(string messages) : base(messages)
        {
        }

        public AlipayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
