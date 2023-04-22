using System;

namespace proba
{
    class Program
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

        class Gardener
        {
            public string Name { get; set; }
            private TomatoBush plant;

            public Gardener(string name, TomatoBush plant)
            {
                Name = name;
                this.plant = plant;
            }

            public void Work() => plant.GrowAll();

            public void Harvest()
            {
                if (plant.AllAreRipe()) plant.GiveAwayAll(); else Console.WriteLine("Не все плоды созрели!");
            }

            static public void KnowledgeBase() => Console.WriteLine("Здравствуйте! Наша компания очень рада, что вы выбрали именно нас и будете работать на нашей ферме томатов. Пожалуйста, будте учтивы и внимательны, ведь наша работа, хоть и может показаться не особо престижной, на самом деле очень важна и требует чрезвычайного внимания. Пожалуйста, приступайте к работе.");

        }
        static void Main(string[] args)
        {
            TomatoBush tomatoBush = new TomatoBush(10);
            Gardener gardener = new Gardener("Vasya", tomatoBush);
            Gardener.KnowledgeBase();
            gardener.Work();
            gardener.Harvest();
            gardener.Work();
            gardener.Work();
            gardener.Work();
            gardener.Harvest();
        }
    }
}