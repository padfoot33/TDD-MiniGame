using NUnit.Framework;
using UnityEngine;
using Tag;

namespace Tests
{
    public class FoodItem_Test
    {
        private FoodItem foodItem;
        private Sprite sprite;

        [SetUp]
        public void Init()
        {
            foodItem = Utility.Instantiate("FoodItem").GetComponent<FoodItem>();
            sprite = Utility.GetSprite("Coin");
        }

        [Test]
        public void Test_SetFoodDatas()
        {
            foodItem.SetFoodData(new FoodData("Panipuri", sprite));
            Assert.AreEqual(sprite.name, foodItem.spriteRenderer.sprite.name);
        }
    }
}
