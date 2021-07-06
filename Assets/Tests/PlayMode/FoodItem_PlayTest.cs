using System.Collections;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;
using Tag;

namespace Tests
{
    public class FoodItem_PlayTest
    {
        private VendingMachine vendingMachine;
        private FoodItem foodItem;
        private FoodData foodData;

        [SetUp]
        public void Init()
        {
            vendingMachine = Utility.Instantiate("VendingMachine", new Vector3(0, 6, 0), Quaternion.identity).GetComponent<VendingMachine>();
            foodData = new FoodData("Panipuri", Utility.GetSprite("Coin"));
            vendingMachine.GenerateFoodItem(foodData);
            foodItem = GameObject.FindObjectOfType<FoodItem>();
        }

        [UnityTest]
        public IEnumerator Test_AddScoreOnSuccessfullStore()
        {
            ContainerBox box = GameObject.FindObjectOfType<ContainerBox>();
            box.GetComponent<Rigidbody2D>().gravityScale = 0;
            int score = DataManager.Instance.Score;
            yield return new WaitForSecondsRealtime(2f);
            Assert.Greater(DataManager.Instance.Score, score);
        }

        [UnityTest]
        public IEnumerator Test_CheckStoreItem()
        {
            ContainerBoxGenerator.Instance.Generate();
            ContainerBox box = GameObject.FindObjectOfType<ContainerBox>();
            box.GetComponent<Rigidbody2D>().gravityScale = 0;
            yield return new WaitForSecondsRealtime(2f);
            Assert.IsTrue(box.isBoxFilled);
        }

        [UnityTest]
        public IEnumerator Test_ItemFall()
        {
            foodItem.transform.position = Vector3.zero;
            Vector3 currentPosition = foodItem.transform.position;
            yield return new WaitForSecondsRealtime(1f);
            Vector3 newPosition = foodItem.transform.position;
            Assert.Less(newPosition.y, currentPosition.y);
        }

        [UnityTest]
        public IEnumerator Test_DestroyOnHitGround()
        {
            ConveyorBelt conveyorBelt = Utility.Instantiate("ConveyorBelt").GetComponent<ConveyorBelt>();
            yield return new WaitForSecondsRealtime(3f);
            Assert.IsTrue(foodItem.Equals(null));
            Utility.DestroyImmediateObject(conveyorBelt);
        }

        [UnityTest]
        public IEnumerator Test_DeductLifeOnHitGround()
        {
            ConveyorBelt conveyorBelt = Utility.Instantiate("ConveyorBelt").GetComponent<ConveyorBelt>();
            int life = LifeManager.Instance.Life;
            yield return new WaitForSecondsRealtime(3f);
            int newLife = LifeManager.Instance.Life;
            Assert.Less(newLife, life);
            Utility.DestroyImmediateObject(conveyorBelt);
        }

        [TearDown]
        public void TearDown()
        {
            Utility.DestroyImmediateObject(vendingMachine);
            if (foodItem != null)
                Utility.DestroyImmediateObject(foodItem);
        }
    }
}