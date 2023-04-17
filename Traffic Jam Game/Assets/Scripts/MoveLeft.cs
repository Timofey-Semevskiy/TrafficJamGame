using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeft : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 10);
        if (transform.position.x >= 30 && gameObject.CompareTag("Gate")) 
        {
            Destroy(gameObject);
        }

        
    }

    
    
}
