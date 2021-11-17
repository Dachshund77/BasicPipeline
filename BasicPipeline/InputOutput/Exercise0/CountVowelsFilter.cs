using System;
using BasicPipeline.Framework;

namespace BasicPipeline.InputOutput.Exercise0
{
    public class CountVowelsFilter : Filter<StringStatistics>
    {
        protected override void Execute(StringStatistics data)
        {
            for (int i = 0; i < data.InputString.Length; i++)
            {
                if("AEIOU".Contains(data.InputString.ToUpper()[i])){
                    data.NumberOfVowels++;
                }
            }
        }
    }
}