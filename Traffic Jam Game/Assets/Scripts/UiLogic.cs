using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiLogic : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Button button;
    [SerializeField] private bool checkOpenUi = false;
    

    public void OpenUiShop()
    {
        if(button== true && checkOpenUi == false)
        {
            animator.SetTrigger("Open");
            checkOpenUi = true; 
            
        }
        else if (button == true && checkOpenUi == true)
        {
            animator.SetTrigger("Close");
            checkOpenUi = false;
        }
    }
  
}
