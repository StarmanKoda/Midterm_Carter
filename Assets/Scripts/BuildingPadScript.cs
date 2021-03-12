using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BuildingPadScript : MonoBehaviour
{
    public GameObject Building;
    public GameObject Placement;
    public bool spacetaken = false;
    public bool isCannon = false;
    public float timer;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            spacetaken = false;
            timer = 0;
        }
    }

    void OnMouseDown()
    {
        if (spacetaken == false && isCannon == true && (InventoryScript.Instance.CannonAmount > 0)&& Time.timeScale == 1f)
        {
            Instantiate(Building, new Vector3(Placement.transform.position.x, Placement.transform.position.y, Placement.transform.position.z), Quaternion.identity);
            spacetaken = true;
            InventoryScript.Instance.CannonAmount -= 1;
        }
        else if (spacetaken == false && isCannon == false && (InventoryScript.Instance.PrinterAmount > 0) && Time.timeScale == 1f)
        {
            Instantiate(Building, new Vector3(Placement.transform.position.x, Placement.transform.position.y, Placement.transform.position.z), Quaternion.identity);
            spacetaken = true;
            InventoryScript.Instance.PrinterAmount -= 1;
        }
    }
}
