namespace ShopApp.Models
{
    public abstract class Chocolate : Sweet
    {
        public Chocolate(
            string name,
            SweetType type,
            double weightInGm,
            string shape,
            string manufacturer,
            double priceInUAH,
            double cocoaPercentage,
            bool isBar)
            : base(name, type, weightInGm, shape, manufacturer, priceInUAH)
        {
            CocoaPercentage = cocoaPercentage;
            IsBar = isBar;
        }

        public double CocoaPercentage { get; set; }
        public bool IsBar { get; set; }
    }
}
