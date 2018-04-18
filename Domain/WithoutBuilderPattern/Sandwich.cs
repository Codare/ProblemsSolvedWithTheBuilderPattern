using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.WithoutBuilderPattern
{
    public class Sandwich
    {
        private readonly BreadType _breadType;
        private readonly CheeseType _cheeseType;
        private readonly MeatType _meatType;
        private readonly bool _isToasted;
        private readonly bool _hasMustard;
        private readonly bool _hasMayo;
        private readonly List<string> _vegetables;

        public Sandwich(BreadType breadType, bool isToasted, CheeseType cheeseType, MeatType meatType, bool hasMustard,
            bool hasMayo, List<string> vegetables)
        {
            _breadType = breadType;
            _isToasted = isToasted;
            _cheeseType = cheeseType;
            _meatType = meatType;
            _hasMustard = hasMustard;
            _hasMayo = hasMayo;
            _vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine($"Sandwich on {_breadType} bread");
            if (_isToasted)
            {
                Console.WriteLine("Toasted");
            }

            if (_hasMayo)
            {
                Console.WriteLine("With Mayo");
            }

            if (_hasMustard)
            {
                Console.WriteLine("With Mustard");
            }

            Console.WriteLine("Meat: {0}", _meatType);
            Console.WriteLine("Cheese: {0}", _cheeseType);
            Console.WriteLine("Veggies:");
            foreach (var vegetable in _vegetables)
                Console.WriteLine("   {0}", vegetable);
        }
    }
}
