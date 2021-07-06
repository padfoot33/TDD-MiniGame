using System;
using UnityEngine;
namespace Tag
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class ContainerBox : MonoBehaviour
    {
        public FoodData requiredFoodData;
        public bool isBoxFilled;
        public SpriteRenderer foodSpriteRenderer;

        public void SetFoodData(FoodData foodData)
        {
            requiredFoodData = foodData;
        }

        public bool IsValidFood(FoodData data)
        {
            return requiredFoodData.id == data.id;
        }

        public void MoveMe(float speed)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector3(50, 0, 0), speed * Time.deltaTime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.collider.name == "DestroyPoint")
            {
                Destroy(gameObject);
            }
        }
    }
}