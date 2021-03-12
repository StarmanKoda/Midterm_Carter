using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TurretSpawner : MonoBehaviour
{
    public GameObject Turret;
    public Transform Stand;

    // Update is called once per frame
    void Update()
    {
        if (MoneyManagement.Instance.balance > MoneyManagement.Instance.BuildingCost)
        {
            Instantiate(Turret,Stand.position,Quaternion.identity);
            MoneyManagement.Instance.balance -= MoneyManagement.Instance.BuildingCost;
        }
    }
}
