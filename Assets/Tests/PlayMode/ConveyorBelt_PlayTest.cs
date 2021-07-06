using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Tag;

namespace Tests
{
    public class ConveyorBelt_PlayTest
    {
        private ConveyorBelt conveyorBelt;

        [SetUp]
        public void Init()
        {
            conveyorBelt = Utility.Instantiate("ConveyorBelt").GetComponent<ConveyorBelt>();
        }

        [UnityTest]
        public IEnumerator Test_IncreaseSpeed()
        {
            float oldSpeed = conveyorBelt.speed;
            float increaseSpeed = 5f;
            yield return new WaitForSecondsRealtime(2f);
            conveyorBelt.IncreaseSpeed(increaseSpeed);

            yield return new WaitForSecondsRealtime(1f);
            Assert.AreEqual(conveyorBelt.speed, oldSpeed + increaseSpeed);
        }

        [TearDown]
        public void TearDown()
        {
            Utility.DestroyImmediateObject(conveyorBelt);
        }
    }
}
