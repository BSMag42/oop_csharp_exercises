using TechReturners.Exercises;

namespace TechReturners.Exercises
{
    public class LionCat : Cat
    {
        public LionCat()
        {
            _averageheight = 1100;
            _setting = "wild";
        }

        public override string Eat
        {
            get => "Roar!!!!";
        }
    }
}