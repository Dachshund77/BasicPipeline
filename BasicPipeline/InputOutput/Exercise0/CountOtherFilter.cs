using System;
using BasicPipeline.Framework;

namespace BasicPipeline.InputOutput.Exercise0
{
    public class CountOtherFilter : Filter<StringStatistics>
    {
        protected override void Execute(StringStatistics data)
        {
            data.NumberOfOtherCharacters = data.InputString.Length - data.NumberOfConsonants - data.NumberOfVowels;
        }
    }
}