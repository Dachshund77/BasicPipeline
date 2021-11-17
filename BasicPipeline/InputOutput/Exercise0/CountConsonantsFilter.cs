using System;
using System.Linq;
using BasicPipeline.Framework;

namespace BasicPipeline.InputOutput.Exercise0
{
    public class CountConsonantFilter : Filter<StringStatistics>
    {
         private char[] consonants = new [] {'B','C','D','F','G','H','J','K','L','M','N','P','Q','R','S','T','V','W','X','Z'};

        protected override void Execute(StringStatistics data)
        {
            data.NumberOfConsonants = data.InputString.ToUpper().Count(s => consonants.Contains(s));
        }
    }
}