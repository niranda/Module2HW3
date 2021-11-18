namespace ShopApp.Models
{
    public abstract class Sweet
    {
        public Sweet(string name, SweetType type, double weightInGm, string shape, string manufacturer, double priceInUAH)
        {
            Name = name;
            Type = type;
            WeightInGm = weightInGm;
            Shape = shape;
            Manufacturer = manufacturer;
            PriceInUAH = priceInUAH;
        }

        public string Name { get; set; }
        public SweetType Type { get; set; }
        public double WeightInGm { get; set; }
        public string Shape { get; set; }
        public string Manufacturer { get; set; }
        public double PriceInUAH { get; set; }
    }
}
