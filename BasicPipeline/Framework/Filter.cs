using System;
using System.Threading.Tasks;

namespace BasicPipeline.Framework
{
    public abstract class Filter<T> : IFilter<T> where T : class
    {
        private IFilter<T> _next;

        public void SetNext(IFilter<T> next)
        {
            this._next = next;
        }

        public async Task Invoke(T input)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Executing {this.GetType().Name} in thread {Task.CurrentId}");
                Execute(input);
                _next?.Invoke(input).Wait();
            });
        }

        protected abstract void Execute(T data);
    }
}