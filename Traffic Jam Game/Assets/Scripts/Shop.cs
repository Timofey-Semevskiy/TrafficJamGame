using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Button buttons;
    public GameObject prefabCar;
    public Transform[] position;
    public int numberPos;
    public static Shop instance = null;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }



        buttons.onClick.AddListener(() => TaskOnClick(Shop.instance.AddCount()));
    }

    void TaskOnClick(int numberPos)
    {
        Instantiate(prefabCar, position[numberPos].transform.position, prefabCar.transform.rotation);
    }

    int AddCount()
    {
        return numberPos++;
    }















    //public void PriceCheck(int price)
    //{
    //    if (tes.counter >= price)
    //    {
    //        SpawnCarButton(nums);
    //    }
    //    else
    //    {
    //        Debug.Log("Low Money");
    //    }
    //}


}
