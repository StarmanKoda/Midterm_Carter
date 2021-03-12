using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using System.Threading;

public class HealthScript : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI HealthDisplay;
    public TextMeshProUGUI TimeDisplay;
    public int countdown = 60;
    public float timer = 0;
    public string losinglevel;
    public string winninglevel;
    void OnTriggerEnter()
    {
        health = health - 25;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (health == 0)
        {
            SceneManager.LoadScene(losinglevel);
        }
        HealthDisplay.text = health.ToString();
        if (timer > 1)
        {
            countdown = countdown - 1;
            TimeDisplay.text = countdown.ToString();
            timer = 0;
        }
        if (countdown == 0)
        {
            SceneManager.LoadScene(winninglevel);
        }
    }
}
