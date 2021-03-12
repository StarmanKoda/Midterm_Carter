using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public string keyName;
    public GameObject menu;
    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(keyName))
        {
            menu.SetActive(!menu.activeInHierarchy);
            isPaused = !isPaused;

            if (isPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
