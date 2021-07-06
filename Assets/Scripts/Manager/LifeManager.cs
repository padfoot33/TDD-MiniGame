using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tag
{
    public class LifeManager : MonoBehaviour
    {
        #region PUBLIC_VARS
        public static LifeManager Instance;

        public int Life { get; private set; }
        #endregion

        #region PRIVATE_VARS

        #endregion

        #region UNITY_CALLBACKS
        private void Awake()
        {
            Instance = this;
            Life = 3;
        }
        #endregion

        #region PUBLIC_FUNCTIONS
        public void UpdateLife(int value)
        {
            Life += value;
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
