using System.Numerics;
using BasicPipeline.Framework;

namespace BasicPipeline.InputOutput.Exercise0
{
    public class StringStatistics
    {
        public string InputString { get; set; }
        public int? NumberOfVowels { get; set; }
        public int? NumberOfConsonants { get; set; }
        public int? NumberOfOtherCharacters { get; set; }

        public StringStatistics(string inputString)
        {
            InputString = inputString;
        }
    }
}


