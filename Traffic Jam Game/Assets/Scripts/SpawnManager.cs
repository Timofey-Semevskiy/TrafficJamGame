using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3((float)-2.7, (float)0.4, (float)8.20);
    public float startdeley = 4;
    public float repeatRate = 4;
    
    void Awake()
    {
        InvokeRepeating("SpawnGate", startdeley, repeatRate);
       
    }
    void SpawnGate()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
    
}
