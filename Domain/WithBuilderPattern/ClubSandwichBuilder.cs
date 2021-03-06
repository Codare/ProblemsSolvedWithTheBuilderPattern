﻿using System.Collections.Generic;
using Domain.Common;

namespace Domain.WithBuilderPattern
{
    /// <summary>
    /// Concrete builder -> One of many concrete builders.
    /// </summary>
    /// <seealso cref="Domain.WithBuilderPattern.SandwichBuilder" />
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            Sandwich.HasMayo = true;
            Sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            Sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void ApplyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Swiss;
            Sandwich.MeatType = MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.White;
            Sandwich.IsToasted = true;
        }
    }
}
