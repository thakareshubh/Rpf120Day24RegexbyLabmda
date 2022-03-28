using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc1EnterValidFirstName
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyserMood()
        {

            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
