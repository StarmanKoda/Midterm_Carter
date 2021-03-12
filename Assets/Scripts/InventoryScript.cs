using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryScript : MonoBehaviour
{
    public int CannonAmount=0;
    public int PrinterAmount=0;
    public TextMeshProUGUI CannonDisplay;
    public TextMeshProUGUI PrinterDisplay;
    public static InventoryScript Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        PrinterDisplay.text = PrinterAmount.ToString();
        CannonDisplay.text = CannonAmount.ToString();
    }

    public void BuyCannon()
    {
        if (MoneyManagement.Instance.balance >= MoneyManagement.Instance.BuildingCost)
        {
            CannonAmount += 1;
            MoneyManagement.Instance.balance -= MoneyManagement.Instance.BuildingCost;
        }
    }

    public void BuyPrinter()
    {
        if (MoneyManagement.Instance.balance >= MoneyManagement.Instance.BuildingCost)
        {
            PrinterAmount += 1;
            MoneyManagement.Instance.balance -= MoneyManagement.Instance.BuildingCost;
        }
    }
}
