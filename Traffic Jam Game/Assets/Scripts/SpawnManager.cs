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
    [SerializeField] private Transform[] spawnPositionCar;
    [SerializeField] private GameObject carPrefab;
    [SerializeField] private Button button;
    [SerializeField] private int nums = 0;
    void Start()
    {
        InvokeRepeating("SpawnGate", startdeley, repeatRate);
        button.onClick.AddListener(() => SpawnCarButton(nums++));
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nums > spawnPositionCar.Length)
        {
            Debug.Log("ÝÝÝ ÁËßÄ");
        }
    }
    void SpawnGate()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
    public void SpawnCarButton(int num)
    {
         Instantiate(carPrefab, spawnPositionCar[num].transform.position, carPrefab.transform.rotation);
   
    }
}
