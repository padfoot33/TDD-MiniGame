using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tag
{
    public class GamePlayManager : MonoBehaviour
    {
        public static GamePlayManager Instance;
        public VendingMachine vendingMachine;
        public Timer timer;

        public void StartGame()
        {
            FoodManager.Instance.Init();
            timer.Init(60);
            UIManager.Instance.gamePlayView.Show();
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
           
        }
    }
}