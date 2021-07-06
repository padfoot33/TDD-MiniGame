using UnityEngine;

namespace Tag
{
    public class ContainerBoxGenerator : MonoBehaviour
    {
        public static ContainerBoxGenerator Instance;
        public ContainerBox containerBoxPrefab;
        public Transform spawanPoint;

        private void Awake()
        {
            Instance = this;
        }

        public void Generate()
        {
            ContainerBox temp = Instantiate(containerBoxPrefab, spawanPoint.position, Quaternion.identity);
            temp.SetFoodData(FoodManager.Instance.GetCurrentFoodButtonData());
        }
    }
}