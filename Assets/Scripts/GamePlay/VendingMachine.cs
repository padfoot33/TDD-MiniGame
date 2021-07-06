using UnityEngine;

namespace Tag
{

    public class VendingMachine : MonoBehaviour
    {
        public FoodItem foodItemPrefab;
        public void GenerateFoodItem(FoodData foodData)
        {
            FoodItem currentFoodItem = Instantiate(foodItemPrefab, transform.position,Quaternion.identity);
            currentFoodItem.SetFoodData(foodData);
            Debug.Log(currentFoodItem.transform.position);
        }
    }
}