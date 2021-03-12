using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPrinter : MonoBehaviour
{
    public float secondsPassed = 0;
    public float printEvery;

    // Update is called once per frame
    void Update()
    {
        secondsPassed = secondsPassed + Time.deltaTime;
        if (printEvery < secondsPassed)
        {
            MoneyManagement.Instance.balance += MoneyManagement.Instance.PrinterPay;
            secondsPassed = 0;
        }


    }
}
