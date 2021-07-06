using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools;
using Tag;
namespace Tests
{
    public class FoodManager_Test
    {
        [UnityTest]
        public IEnumerator Test_GenerateFoodButton()
        {
            yield return null;
            Assert.AreEqual(FoodManager.Instance.numberOfButtons,FoodManager.Instance.foodbuttonList.Count);
        }
        [Test]
        public void Test_SetFoodButtonData()
        {
            foreach (var item in FoodManager.Instance.foodbuttonList)
            {
                Assert.IsTrue(item.foodData != null);
            }
        }
        [Test]
        public void Test_GetFoodData()
        {
            List<FoodData> foodDatas = new List<FoodData>();
            foreach (var item in FoodManager.Instance.foodbuttonList)
            {
                foodDatas.Add(item.foodData);
            }

            Assert.IsTrue(foodDatas.Contains(FoodManager.Instance.GetCurrentFoodButtonData()));
        }
        [TearDown]
        public void TearDown()
        {
        }
    }
}
