using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tes : MonoBehaviour
{
    public string collisions = "0";
    public float counter = 0;
    public Text text;
    

    public static tes instance { get; private set; }

    private void Awake()
    {
        if (text == null)
        {
            text = GameObject.Find("Text").GetComponent<Text>();

        }
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        collisions = counter.ToString();
        text.text = "Gate Count" + counter;
    }

    public void AddCounterFull(int incom)
    {
        counter += incom;
    }
    public void AddCounterHalf()
    {
        counter += .5f;
    }
}
