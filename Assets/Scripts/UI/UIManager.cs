using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tag
{
    public class UIManager : MonoBehaviour
    {
        #region PUBLIC_VARS
        public static UIManager Instance;
        public HomeView homeView;
        public GamePlayView gamePlayView;
        #endregion

        #region PRIVATE_VARS

        #endregion

        #region UNITY_CALLBACKS
        private void Awake()
        {
            Instance = this;
        }
        #endregion

        #region PUBLIC_FUNCTIONS

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
