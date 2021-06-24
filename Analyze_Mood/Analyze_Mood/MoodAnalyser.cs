using System;
using System.Collections.Generic;
using System.Text;
using MoodAnalyserException;

namespace Analyze_Mood
{

    public class Analysis
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Analysis()
        {
            try
            {
                throw new HappyMoodAnalyserException("HAPPY");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="userInput"></param>
        public Analysis(string userInput)
        {
            try
            {
                if (userInput == "sad")
                {
                    throw new SadMoodAnalyserException("SAD");
                }
                if (userInput == "happy")
                {
                    throw new HappyMoodAnalyserException("HAPPY");
                }
                else
                {
                    throw new InvalidMoodAnalyserException("null");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
    }
    
}

