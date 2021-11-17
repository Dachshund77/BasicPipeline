using System;
using BasicPipeline.Framework;

namespace BasicPipeline.InputOutput.Exercise0
{
    public class PrintResultFilter : Filter<StringStatistics>
    {
        protected override void Execute(StringStatistics data)
        {
            Console.WriteLine("Statics for: {0}", data.InputString);
            Console.WriteLine("Number of vowels: {0}", data.NumberOfVowels);
            Console.WriteLine("Number of consonants: {0}", data.NumberOfConsonants);
            Console.WriteLine("Number of others: {0}", data.NumberOfOtherCharacters);
        }
    }
}