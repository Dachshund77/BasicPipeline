using System;
using System.Linq;
using BasicPipeline.Framework;

namespace BasicPipeline.InputOutput.Exercise0
{
    public class CountVowelsFilter : Filter<StringStatistics>
    {
        private char[] vowels = new [] {'A','E','I','O','U'};

        protected override void Execute(StringStatistics data)
        {
            data.NumberOfVowels = data.InputString.ToUpper().Count(s => vowels.Contains(s));
        }
    }
}