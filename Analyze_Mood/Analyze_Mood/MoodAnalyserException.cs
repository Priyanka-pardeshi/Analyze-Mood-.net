using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserException
{
    class HappyMoodAnalyserException:Exception
    {
        public HappyMoodAnalyserException(string message) : base(message)
        { 
        }
    }
    class SadMoodAnalyserException : Exception
    {
        public SadMoodAnalyserException(string Message) : base(Message)
        { 
        }
    }
}
