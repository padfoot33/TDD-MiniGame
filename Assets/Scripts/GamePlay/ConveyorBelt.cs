using System;
using UnityEngine;
namespace Tag
{
    public class ConveyorBelt : MonoBehaviour
    {
        public float speed = 0.1f;

        private void OnCollisionStay2D(Collision2D collision)
        {
            ContainerBox box = collision.gameObject.GetComponent<ContainerBox>();
            if (box)
            {
                box.MoveMe(speed);
            }
        }

        public void IncreaseSpeed(float value)
        {
            speed += value;
        }
    }
}