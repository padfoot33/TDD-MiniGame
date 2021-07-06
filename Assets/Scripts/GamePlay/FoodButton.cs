using UnityEngine;

namespace Tag
{
    public class FoodButton : MonoBehaviour
    {
        public FoodData foodData;
        public void Click()
        {
            GamePlayManager.Instance.vendingMachine.GenerateFoodItem(foodData);
        }
        public void SetFoodData(FoodData foodData)
        {
            this.foodData = foodData;
        }
    }
}