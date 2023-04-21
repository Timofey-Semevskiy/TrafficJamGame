using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonClick : MonoBehaviour
{
    public Button buttons;
    public GameObject cube;
    public Transform[] position;
    public int numberPos;
    public static ButtonClick instance = null;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance == this)
        {
            Destroy(gameObject);
        }



        buttons.onClick.AddListener(() =>TaskOnClick(ButtonClick.instance.AddCount()));
    }

    void TaskOnClick(int numberPos)
    {
        Instantiate(cube, position[numberPos].transform.position, cube.transform.rotation);
    }

    int AddCount()
    {
       return numberPos++;
    }
}
