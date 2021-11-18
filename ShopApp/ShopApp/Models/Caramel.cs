namespace ShopApp.Models
{
    public class Caramel : Sweet
    {
        public Caramel(
            string name,
            SweetType type,
            double weightInGm,
            string shape,
            string manufacturer,
            double priceInUAH,
            string caramelType,
            string color)
            : base(name, type, weightInGm, shape, manufacturer, priceInUAH)
        {
            CaramelType = caramelType;
            Color = color;
        }

        public string CaramelType { get; set; }
        public string Color { get; set; }
    }
}
