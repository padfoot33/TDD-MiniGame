using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tag
{
    public class DataManager : MonoBehaviour
    {
        #region PUBLIC_VARS
        public static DataManager Instance;
        public int Score { get; private set; }
        #endregion

        #region PRIVATE_VARS

        #endregion

        #region UNITY_CALLBACKS
        void Awake()
        {
            Instance = this;
        }
        #endregion

        #region PUBLIC_FUNCTIONS
        public void UpdateScore(int increment)
        {
            Score += increment;
        }
        #endregion

        #region PRIVATE_FUNCTIONS

        #endregion

        #region CO-ROUTINES

        #endregion

        #region EVENT_HANDLERS

        #endregion

        #region UI_CALLBACKS       

        #endregion
    }
}
