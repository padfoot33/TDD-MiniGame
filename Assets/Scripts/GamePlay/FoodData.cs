using UnityEngine;

namespace Tag
{
    /// <summary>
    /// Food Data represents the base level component of this game.
    /// </summary>
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
