using proba.TomatoBushes;
namespace proba.Gardeners
{
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
            if (plant.AllAreRipe())
            {
                plant.GiveAwayAll();
            }
            else Console.WriteLine("Не все плоды созрели!");
        }

        static public void KnowledgeBase() => Console.WriteLine("Здравствуйте! Наша компания очень рада, что вы выбрали именно нас и будете работать на нашей ферме томатов. Пожалуйста, будте учтивы и внимательны, ведь наша работа, хоть и может показаться не особо престижной, на самом деле очень важна и требует чрезвычайного внимания. Пожалуйста, приступайте к работе.");

    }
}