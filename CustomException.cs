using System;

namespace ExceptionChallenge
{
    // Définition de la CustomException qui hérite de Exception
    public class CustomException : Exception
    {
        public DateTime ExceptionTime { get; }

        public CustomException(string message) : base(message)
        {
            ExceptionTime = DateTime.Now;
        }
    }
}
