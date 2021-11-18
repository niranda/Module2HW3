namespace ShopApp.Models
{
    public class FilledChocolate : MilkChocolate
    {
        public FilledChocolate(
           string name,
           SweetType type,
           double weightInGm,
           string shape,
           string manufacturer,
           double priceInUAH,
           double cocoaPercentage,
           bool isBar,
           double milkPowderPercentage,
           string fillingType)
           : base(name, type, weightInGm, shape, manufacturer, priceInUAH, cocoaPercentage, isBar, milkPowderPercentage)
        {
            FillingType = fillingType;
        }

        public string FillingType { get; set; }
    }
}
