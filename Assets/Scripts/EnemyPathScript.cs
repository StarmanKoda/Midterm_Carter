using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPathScript : MonoBehaviour
{
    public GameObject target;
    public NavMeshAgent pathFinding;
    
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        target = GameObject.Find("Goal");
    }

    // Update is called once per frame
    void Update()
    {
        pathFinding.SetDestination(target.transform.position);
    }
    public void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
