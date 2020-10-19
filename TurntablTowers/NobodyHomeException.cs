using System;
namespace TurntablTowers
{
    public class NobodyHomeException : Exception
    {
        public NobodyHomeException(string message):base(message)
        {
        }

        public NobodyHomeException(string message, Exception cause):base(message,cause)
        {

        }
    }
}
