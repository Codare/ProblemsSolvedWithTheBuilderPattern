using System.Collections.Generic;
using Domain.Common;

namespace Domain.WithBuilderPattern
{
    public class TurkeyCheesSwizzlerSandwichBuilder : SandwichBuilder
    {
        //For example.  ICmsContentProvider.GetContent
        //public TurkeyCheesSwizzlerSandwichBuilder(ICmsContentProvider cmsContentProvider)
        //{
        //}

        //for explanation purposes of the pattern we have hard coded the parameters.

        public override void AddCondiments()
        {
            //Client concerns have been pulled up into a dedicated builder class.
            Sandwich.HasMayo = false;
            Sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            //Client concerns have been pulled up into a dedicated builder class.
            Sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            //Client concerns have been pulled up into a dedicated builder class.
            Sandwich.CheeseType = CheeseType.Cheddar;
            Sandwich.MeatType = MeatType.Turkey;
        }

        public override void PrepareBread()
        {
            //Client concerns have been pulled up into a dedicated builder class.
            Sandwich.BreadType = BreadType.White;
            Sandwich.IsToasted = true;
        }
    }
}
