using NUnit.Framework;
using UnityEngine;
using Tag;

namespace Tests
{
    public class VendingMachine_Test
    {
        private VendingMachine vendingMachine;
        private FoodData foodData;
        private FoodItem foodItem;

        [OneTimeSetUp]
        public void OneTimeInit()
        {
            vendingMachine = Utility.Instantiate("VendingMachine").GetComponent<VendingMachine>();
            foodData = new FoodData("Panipuri",Utility.GetSprite("Coin"));
        }

        [SetUp]
        public void Init()
        {
             vendingMachine.GenerateFoodItem(foodData);
            foodItem = GameObject.FindObjectOfType<FoodItem>();
        }

        [TearDown]
        public void TearDown()
        {
            Utility.DestroyImmediateObject(foodItem);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Utility.DestroyImmediateObject(vendingMachine);
        }

        [Test]
        public void Test_GenerateFoodItem()
        {
            Assert.IsTrue(foodItem != null);
        }

        [Test]
        public void Test_GenerateFoodItemOnVendingMachine()
        {
            Assert.AreEqual(vendingMachine.transform.position, foodItem.transform.position);
        }
    }
}
