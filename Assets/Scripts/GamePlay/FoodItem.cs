using UnityEngine;
using Tag;

namespace Tag
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class FoodItem : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer;
        public FoodData foodData;

        public void SetFoodData(FoodData data)
        {
            foodData = data;
        }

        public string GetUniqueId()
        {
            return foodData.id;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            ContainerBox containerBox = collision.collider.GetComponent<ContainerBox>();
            if (containerBox != null && containerBox.IsValidFood(foodData))
            {
                Debug.Log(collision.gameObject.name);
                DataManager.Instance.UpdateScore(1);
                containerBox.isBoxFilled = true;
                Destroy(gameObject);
            }
            else if (collision.collider.GetComponent<ConveyorBelt>() != null)
            {
                LifeManager.Instance.UpdateLife(-1);
                Destroy(gameObject);
            }
        }
    }
}