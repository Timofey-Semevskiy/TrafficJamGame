using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWheels : MonoBehaviour
{
    [SerializeField] GameObject wheels;


    private void Update()
    {
        wheels.transform.Rotate(Time.deltaTime * 300, 0, 0);
    }
}
