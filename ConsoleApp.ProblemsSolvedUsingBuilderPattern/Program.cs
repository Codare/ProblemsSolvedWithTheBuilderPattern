using System;
using System.Collections.Generic;
using Domain.Common;
using Domain.WithBuilderPattern;
using WithoutBuilderPattern = Domain.WithoutBuilderPattern;
using WithoutCtorButWithPublicParameters = Domain.WithNoCtorPublicSetterParameters;

namespace ConsoleApp.ProblemsSolvedUsingBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programs that have too many parameters are often a good candidate for the builder pattern!");

            var myBloatedParameterSandwich = new WithoutBuilderPattern.Sandwich(BreadType.Wheat, true, CheeseType.American, MeatType.Chicken, false, true, new List<string>() { "carrots", "peppers" });

            myBloatedParameterSandwich.Display();

            //Again with this approach the responsibility is on the client code to get it right.  It must know which parameters/properties it must set and have exposed to it.
            //the types/enums inner workings of the Sandwich class.
            var mySlightyBetterCtorLessParametersGuessingSandwich = new WithoutCtorButWithPublicParameters.Sandwich();

            mySlightyBetterCtorLessParametersGuessingSandwich.BreadType = BreadType.Wheat;
            mySlightyBetterCtorLessParametersGuessingSandwich.CheeseType = CheeseType.American;

            //The other boolean parameters  such as:
            /*
             * isToasted, hasMustard, hasMayo => will all have default values of false.
             *
             * The importance of the client setting them or not is unknown.
             */

            //Also if the client forgets to set just one of the many parameters/properties on the complex class then bugs can occur.
            //For instance if we were to comment out the below lines then a runtime exception of null will occur due to the vegetables not being set to an empty list.
            //mySlightyBetterCtorLessParametersGuessingSandwich.Vegetables = new List<string>() {"carrots", "peppers"};
            mySlightyBetterCtorLessParametersGuessingSandwich.Vegetables = new List<string>() { "carrots", "peppers" };

            mySlightyBetterCtorLessParametersGuessingSandwich.Display();

            //Now to use the Builder Pattern.  note: How the client concerns of methods above have been extracted away.
            //These builder classes could have in themselves, setting or content services injected into them to allow them to build more line of business objects
            //By coding in such a way as to use the builder pattern, accidentally forgetting to set the vegetables, breadType, cheeseType etc is not possible.
            //This is due to the builders logic which is encapsulated.
            var turkeyCheesSwizzlerSandwichMaker = new SandwichMaker(new TurkeyCheesSwizzlerSandwichBuilder());
            turkeyCheesSwizzlerSandwichMaker.BuildSandwich();
            var turkeyCheesSwizzlerSandwich = turkeyCheesSwizzlerSandwichMaker.GetSandwhich();

            turkeyCheesSwizzlerSandwich.Display();

            //Now another variety of sandwich.

            var clubSandwichMaker = new SandwichMaker(new ClubSandwichBuilder());
            clubSandwichMaker.BuildSandwich();
            var clubSandwich = clubSandwichMaker.GetSandwhich();

            clubSandwich.Display();

            Console.ReadLine();
        }
    }
}
