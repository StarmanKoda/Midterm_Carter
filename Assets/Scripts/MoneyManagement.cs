using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MoneyManagement : MonoBehaviour
{
    public int BuildingCost = 50;
    public int PrinterPay = 50;
    public TextMeshProUGUI MoneyDisplay;

    public int balance = 200;

    public static MoneyManagement Instance;

    private void Start()
    {
        Instance = this;
    }
    private void Update()
    {
        MoneyDisplay.text = balance.ToString();
    }
}
