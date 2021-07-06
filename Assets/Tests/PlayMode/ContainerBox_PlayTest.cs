using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Tag;

namespace Tests
{
    public class ContainerBox_PlayTest
    {
        private ConveyorBelt conveyorBelt;
        private ContainerBox containerBox;

        [SetUp]
        public void Init()
        {
            conveyorBelt = Utility.Instantiate("ConveyorBelt").GetComponent<ConveyorBelt>();
            ContainerBoxGenerator.Instance.Generate();
            containerBox = GameObject.FindObjectOfType<ContainerBox>();
        }

        [UnityTest]
        public IEnumerator Test_Move()
        {
            Vector3 currentPosition = ContainerBoxGenerator.Instance.spawanPoint.position;
            yield return new WaitForSecondsRealtime(0.7f);
            Vector3 newPosition = containerBox.transform.position;
            Assert.Less(currentPosition.x, newPosition.x);
        }

        [UnityTest]
        public IEnumerator Test_Destroy()
        {
            yield return new WaitForSecondsRealtime(5f);
            Assert.IsTrue(containerBox.Equals(null));
        }

        [TearDown]
        public void TearDown()
        {
            Utility.DestroyImmediateObject(conveyorBelt);
            if (containerBox != null)
                Utility.DestroyImmediateObject(containerBox);
        }
    }
}
