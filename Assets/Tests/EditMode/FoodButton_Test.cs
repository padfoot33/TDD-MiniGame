using NUnit.Framework;
using UnityEngine;
using Tag;

namespace Tests
{
    public class FoodButton_Test
    {
        private FoodButton foodButton;
        private FoodItem foodItem;

        [SetUp]
        public void Init()
        {
            foodButton = Utility.Instantiate("FoodButton").GetComponent<FoodButton>();
        }

        [TearDown]
        public void TearDown()
        {
            Utility.DestroyImmediateObject(foodButton);
            if (foodItem != null)
                Utility.DestroyImmediateObject(foodItem);
        }

        [Test]
        public void Test_FoodItemNotNull()
        {
            Assert.IsNotNull(foodButton.foodData);
        }

        [Test]
        public void Test_GenerateFoodItem()
        {
            foodButton.Click();
            foodItem = GameObject.FindObjectOfType<FoodItem>();
            Assert.IsNotNull(foodItem);
        }
    }
}
