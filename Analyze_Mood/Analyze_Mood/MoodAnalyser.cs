using System;
using System.Collections.Generic;
using System.Text;
using MoodAnalyserException;

namespace Analyze_Mood
{
    
        public class Analysis
        {
            public Analysis(string userInput)
            {
                try
                {
                    if (userInput == "I am sad Mood")
                    {
                        throw new SadMoodAnalyserException("SAD");
                    }
                    throw new HappyMoodAnalyserException("HAPPY");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    
}

