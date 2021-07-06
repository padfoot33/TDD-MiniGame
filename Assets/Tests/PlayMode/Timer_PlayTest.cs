using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Tag;

namespace Tests
{
    public class Timer_PlayTest
    {
        float maxTime = 60;
        [SetUp]
        public void SetUp()
        {
            GamePlayManager.Instance.timer.Init(maxTime);
            GamePlayManager.Instance.timer.StartTimer();
        }

        [Test]
        public void Test_InitTime()
        {
            Assert.AreEqual(maxTime, GamePlayManager.Instance.timer.GetCurrentTime());
        }

        [UnityTest]
        public IEnumerator Test_CheckTimer()
        {
            float startTime = GamePlayManager.Instance.timer.GetCurrentTime();
            yield return new WaitForSeconds(1.1f);
            Assert.AreEqual((int)--startTime, (int)GamePlayManager.Instance.timer.GetCurrentTime());
        }

        [UnityTest]
        public IEnumerator Test_GenerateBoxAfterDelay()
        {
            yield return new WaitForSeconds(12.5f);
            Assert.AreEqual(5, GameObject.FindObjectsOfType<ContainerBox>().Length);
        }

        [TearDown]
        public void TearDown()
        {
            GamePlayManager.Instance.timer.StopTimer();
            foreach (var item in GameObject.FindObjectsOfType<ContainerBox>())
            {
                Utility.DestroyImmediateObject(item);
            }
        }
    }
}
