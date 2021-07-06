using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tag
{
    public class FoodManager : MonoBehaviour
    {
        #region PUBLIC_VARS
        public static FoodManager Instance;
        public int numberOfButtons;
        public FoodButton buttonPrefab;
        public List<FoodData> foodDataList;
        public List<FoodButton> foodbuttonList;
        #endregion

        #region PRIVATE_VARS
        private List<FoodData> remainingFoodList = new List<FoodData>();
        #endregion

        #region UNITY_CALLBACKS
        private void Awake()
        {
            Instance = this;
        }

        #endregion

        #region PUBLIC_FUNCTIONS
        public void Init()
        {
            GenerateButton();
        }
        public FoodData GetCurrentFoodButtonData()
        {
            return foodbuttonList[Random.Range(0, foodbuttonList.Count)].foodData;
        }
        #endregion

        #region PRIVATE_FUNCTIONS
        private void GenerateButton()
        {
            foodbuttonList.Clear();
            remainingFoodList = foodDataList;
            for (int i = 0; i < numberOfButtons; i++)
            {
                FoodButton instance = Instantiate(buttonPrefab,UIManager.Instance.gamePlayView.buttonPannelTransform);
                instance.SetFoodData(GetRandomFoodData());
                foodbuttonList.Add(instance);
            }
        }
        private FoodData GetRandomFoodData()
        {
            int random = Random.Range(0, remainingFoodList.Count);
            FoodData data = remainingFoodList[random];
            remainingFoodList.Remove(data);
            return data;
        }
        #endregion

        #region CO-ROUTINES

        #endregion

        #region EVENT_HANDLERS

        #endregion

        #region UI_CALLBACKS       

        #endregion
    }
}
