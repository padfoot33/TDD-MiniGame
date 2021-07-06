using NUnit.Framework;
using UnityEngine;
using Tag;

namespace Tests
{
    public class SetUp
    {
        [OneTimeSetUp]
        public void Test_OneTimeSetUp()
        {
            Utility.Init();
            LifeManager.Instance = Utility.Instantiate("LifeManager").GetComponent<LifeManager>();
            DataManager.Instance = Utility.Instantiate("DataManager").GetComponent<DataManager>();
            FoodManager.Instance = Utility.Instantiate("FoodManager").GetComponent<FoodManager>();
            ContainerBoxGenerator.Instance = Utility.Instantiate("ContainerBoxGenerator").GetComponent<ContainerBoxGenerator>();
            GamePlayManager.Instance = Utility.Instantiate("GamePlayManager").GetComponent<GamePlayManager>();
        }

        [OneTimeTearDown]
        public void Test_OneTimeTearDown()
        {
        }
    }
}