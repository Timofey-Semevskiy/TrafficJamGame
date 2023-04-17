using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOne : MonoBehaviour
{

    [SerializeField] private int incom;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            tes.instance.AddCounterFull(incom);
        }
        else
        {
            tes.instance.AddCounterHalf();
        }
    }
}
