using System.Collections;
using UnityEditor;
using UnityEngine;
namespace Tag
{
    public class Timer : MonoBehaviour
    {
        private float currentTime;
        private Coroutine coroutineTimer;

        public float GetCurrentTime()
        {
            return currentTime;
        }

        public void Init(float time)
        {
            currentTime = time;
            StartTimer();
        }

        public void StartTimer()
        {
            StopTimer();
            coroutineTimer = StartCoroutine(TimerCo());
        }

        public IEnumerator TimerCo()
        {
            while (currentTime > 0)
            {
                if ((int)currentTime % 3 == 0)
                    ContainerBoxGenerator.Instance.Generate();
                yield return new WaitForSeconds(1f);
                currentTime--;
            }
        }

        public void StopTimer()
        {
            if (coroutineTimer != null)
                StopCoroutine(coroutineTimer);
        }
    }
}