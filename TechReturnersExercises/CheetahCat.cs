using TechReturners.Exercises;

namespace TechReturners.Exercises
{
    public class CheetahCat : Cat
    {
        public CheetahCat()
        {
            _averageheight = 700;
            _setting = "wild";
        }

        public override string Eat
        {
            get => "Zzzzzzz";
        }
    }
}