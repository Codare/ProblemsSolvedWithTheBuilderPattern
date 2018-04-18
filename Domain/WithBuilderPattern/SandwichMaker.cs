using Domain.WithNoCtorPublicSetterParameters;

namespace Domain.WithBuilderPattern
{
    /// <summary>
    /// Director part of the UML Diagram.
    /// </summary>
    public class SandwichMaker
    {
        private readonly SandwichBuilder _builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            this._builder = builder;
        }

        public void BuildSandwich()
        {
            _builder.CreateNewSandwich();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVegetables();
            _builder.AddCondiments();
        }

        public Sandwich GetSandwhich()
        {
            return _builder.GetSandwich();
        }
    }
}
