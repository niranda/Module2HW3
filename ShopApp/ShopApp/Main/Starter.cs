using ShopApp.Models;
using ShopApp.Services;
using ShopApp.Helpers;

namespace StyleCop.Main
{
    public class Starter
    {
        private readonly GiftService _giftService;
        private readonly LoggerService _notification;
        private readonly SortService _sort;

        public Starter()
        {
            _giftService = GiftService.Instance;
            _notification = LoggerService.Instance;
            _sort = new SortService();
        }

        public void Run()
        {
            var blackCowCandy = new FilledChocolate("Black Cow", SweetType.Chocolate, 10.34, "Cube", "Big Candy Ltd.", 15, 48, false, 30, "Condensed milk");

            var darkPleasureChocolateBar = new BitterChocolate("Dark Pleasure", SweetType.Chocolate, 100.466, "Parallelepiped", "Tasty and Cheap Inc.", 45, 87, true, 17);

            var deliciousLollipopCaramel = new Caramel("Delicious Lollipop", SweetType.Caramel, 6.314, "Sphere", "Big Candy Ltd.", 8, "Lollipop", "Orange");

            var milkyRoadChocolateBar = new FilledChocolate("Milky Road", SweetType.Chocolate, 120.6, "Parallelepiped", "Good Food Inc.", 40, 44, true, 23, "Strawberry jam");

            var availableSweets = new Sweet[4] { blackCowCandy, darkPleasureChocolateBar, deliciousLollipopCaramel, milkyRoadChocolateBar };

            _giftService.BuildGift(availableSweets);
            var builtGift = _giftService.GetGift();
            var giftWeight = _giftService.GetGiftWeight();
            _notification.SuccessfulBuildLog(builtGift, giftWeight);

            var sortedByPriceGift = _sort.SortByPrice(builtGift);
            _notification.SuccessfulSortLog(sortedByPriceGift);

            var chocolateSweetsGift = _giftService.FindByСriterion(SweetType.Chocolate);
            _notification.SuccessfulSearchLog(chocolateSweetsGift);

            var caramelSweetsGift = _giftService.FindByСriterion(SweetType.Caramel);
            _notification.SuccessfulSearchLog(caramelSweetsGift);
        }
    }
}
