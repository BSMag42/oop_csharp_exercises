using System;
using System.Collections.Generic;
using System.Text;

namespace TechReturners.Exercises
{
    public abstract class Cat : ICat
    {
        protected int _averageheight;
        protected string _setting;
        protected bool _asleep = false;

        public abstract string Eat { get; }

        public void WakeUp()
        {
            _asleep = false;
        }

        public void GoToSleep() 
        {
            _asleep = true;
        }

        public int AverageHeight{ get { return _averageheight; } }
        public bool IsAsleep { get { return _asleep; } }
        public string Setting { get { return _setting; } }

    }

    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            _averageheight = 23;
            _setting = "domestic";
        }
     
        public override string Eat
        {
            get => "Purrrrrrr";
        }

    }


}