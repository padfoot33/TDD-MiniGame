using System;
using UnityEngine;
namespace Tag
{
    /// <summary>
    /// Class represents an entity called Container Box, in which Food Item will be collected.
    /// </summary>
    /// <remarks>
    /// When collecting the Food Item, this class will only store food data from it.
    /// </remarks>
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
        /// <summary>
        /// This fucntion is used when collecting FoodData from FooDItem,
        /// </summary>
        /// <param name="data">FoodData passed from FoodItem on collision hit</param>
        /// <returns> Return true if the FoodData it wants and the FoodData it gets from the FoodItem are same </returns>
        public bool IsValidFood(FoodData data)
        {
            return requiredFoodData.id == data.id;
        }
        /// <summary>
        /// Moves the Container box.
        /// </summary>
        /// <param name="speed">Speed through which it should move</param>
        /// <remarks> This fucntion is called when ContainerBox is on conveyor belt </remarks>
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