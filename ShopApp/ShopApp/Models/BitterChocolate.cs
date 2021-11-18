namespace ShopApp.Models
{
    public class BitterChocolate : Chocolate
    {
        public BitterChocolate (
            string name,
            SweetType type,
            double weightInGm,
            string shape,
            string manufacturer,
            double priceInUAH,
            double cocoaPercentage,
            bool isBar,
            double sugarPercentage)
            : base(name, type, weightInGm, shape, manufacturer, priceInUAH, cocoaPercentage, isBar)
        {
            SugarPercentage = sugarPercentage;
        }

        public double SugarPercentage { get; set; }
    }
}
