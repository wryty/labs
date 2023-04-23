
namespace proba.Tomatoes
{
    enum States
    {
        NONE,
        BLOOM,
        GREEN,
        RED
    }
    class Tomato
    {
        States state;
        private int index;
        public Tomato(int index, States state)
        {
            this.index = index;
            this.state = state;
        }

        public void Grow()
        {
            if (this.state == States.RED) return;
            else this.state++;
        }
        public bool IsRipe() => this.state == States.RED;
    }
}