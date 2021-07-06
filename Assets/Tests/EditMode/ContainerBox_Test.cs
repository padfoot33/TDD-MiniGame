using NUnit.Framework;
using Tag;
namespace Tests
{
    public class ContainerBox_Test
    {
        private ContainerBox containerBox;
        private FoodData foodData;
        [SetUp]
        public void Init()
        {
            containerBox = Utility.Instantiate("ContainerBox").GetComponent<ContainerBox>();
            foodData = new FoodData("Panipuri",Utility.GetSprite("Coin"));
            containerBox.SetFoodData(foodData);
        }

        [Test]
        public void Test_MatchFoodElementsIDWithMethod()
        {
            Assert.IsTrue(containerBox.IsValidFood(foodData));
        }

        [Test]
        public void Test_InitContainerBox()
        {
            Assert.IsNotNull(containerBox.foodSpriteRenderer);
            Assert.IsNotNull(containerBox.foodSpriteRenderer.sprite);
        }
    }
}