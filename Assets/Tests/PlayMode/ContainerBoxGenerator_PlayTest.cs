using NUnit.Framework;
using Tag;
using UnityEngine;
namespace Tests
{
    public class ContainerBoxGenerator_PlayTest
    {
        private ContainerBox containerBox;
        [SetUp]
        public void Init()
        {
            //containerBox = Utility.Instantiate("ContainerBox").GetComponent<ContainerBox>();
            //ContainerBoxGenerator.Instance.containerBoxPrefab = containerBox;
        }

        [Test]
        public void Test_GenerateContainerBox()
        {
            ContainerBoxGenerator.Instance.Generate();
            Assert.IsNotNull(GameObject.FindObjectOfType<ContainerBox>());
        }
        [TearDown]
        public void TearDown()
        {
        }
    }
}
