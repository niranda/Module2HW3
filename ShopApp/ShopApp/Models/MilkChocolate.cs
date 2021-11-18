namespace ShopApp.Models
{
    public abstract class MilkChocolate : Chocolate
    {
        public MilkChocolate(
            string name,
            SweetType type,
            double weightInGm,
            string shape,
            string manufacturer,
            double priceInUAH,
            double cocoaPercentage,
            bool isBar,
            double milkPowderPercentage)
            : base(name, type, weightInGm, shape, manufacturer, priceInUAH, cocoaPercentage, isBar)
        {
            MilkPowderPercentage = milkPowderPercentage;
        }

        public double MilkPowderPercentage { get; set; }
    }
}
