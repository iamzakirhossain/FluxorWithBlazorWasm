using Fluxor;

namespace FluxorWithBlazorWasm.State.Counter
{
    [FeatureState]
    public class CounterState
    {
        public int ClickCount { get; }

        private CounterState() { }
        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }
    }
}
