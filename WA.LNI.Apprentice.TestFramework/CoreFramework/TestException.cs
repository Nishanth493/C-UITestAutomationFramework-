using System;
using System.Runtime.Serialization;

namespace WA.LNI.Apprentice.TestFramework
{
    [Serializable]
    public class TestException : Exception
    {
        public TestException()
        {
            Console.WriteLine("Test Case Failed");
        }

        public TestException(string message) : base(message)
        {
            Console.WriteLine("Test Failed due to : "+message);
        }

        public TestException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine("Test Failed due to : " + message+" and caused by exception :"+ innerException);
        }

        protected TestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        // To Do
    }
}