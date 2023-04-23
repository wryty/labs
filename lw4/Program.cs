using System;
using proba.TomatoBushes;
using proba.Gardeners;
namespace proba
{
    class Program
    {
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