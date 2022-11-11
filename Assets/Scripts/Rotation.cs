using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    // Rotate around the z axis at a constant speed
    public class ConstantRotation : MonoBehaviour
    {
        public float degreesPerSecond = 10.0f;
        void fixedUpdate()
        {
            transform.Rotate(10, 15, degreesPerSecond * Time.deltaTime);
        }
    }
}

