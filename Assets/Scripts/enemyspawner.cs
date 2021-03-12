using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class enemyspawner : MonoBehaviour
{
    public Transform spawnLocation;
    public Transform target;
    public GameObject[] enemyprefab;
    [SerializeField]
    private float secondsPassed=0;
    public int SpawnEverySeconds;
    public int arraynumber;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsPassed = secondsPassed + Time.deltaTime;
        if (secondsPassed > SpawnEverySeconds)
        {
            secondsPassed = 0;

            arraynumber = UnityEngine.Random.Range(0, 2);
            GameObject temp = Instantiate(enemyprefab[arraynumber], spawnLocation.position, Quaternion.identity);
            

        }
    }
}
