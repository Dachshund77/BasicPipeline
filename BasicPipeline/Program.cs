using BasicPipeline.Framework;
using BasicPipeline.InputOutput.Exercise0;

namespace BasicPipeline
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }

        static void Ex1(){
            Pipeline<StringStatistics> pipeline = new Pipeline<StringStatistics>();

            pipeline.SetNext(new CountVowelsFilter());
            pipeline.SetNext(new CountConsonantFilter());
            pipeline.SetNext(new CountOtherFilter());
            pipeline.SetNext(new PrintResultFilter());

            pipeline.Invoke(new StringStatistics("Hello World")).Wait();
        }
    }
}