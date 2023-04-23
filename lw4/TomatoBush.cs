using proba.Tomatoes;
namespace proba.TomatoBushes
{
    class TomatoBush
    {
        private Tomato[] tomatoes;
        public TomatoBush(int count)
        {
            tomatoes = new Tomato[count];
            for (int i = 0; i < count; i++) tomatoes[i] = new Tomato(i, States.NONE);
        }

        public void GrowAll() => Array.ForEach<Tomato>(tomatoes, a => a.Grow());

        public bool AllAreRipe() => Array.TrueForAll<Tomato>(tomatoes, a => a.IsRipe());

        public void GiveAwayAll() => tomatoes = new Tomato[0];
    }
}