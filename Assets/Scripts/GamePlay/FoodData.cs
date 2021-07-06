using UnityEngine;

namespace Tag
{
    [System.Serializable]
    public class FoodData
    {
        public string id;
        public Sprite sprite;

        public FoodData(string id, Sprite sprite)
        {
            this.sprite = sprite;
            this.id = id;
        }
    }
}
