using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class musicscript : MonoBehaviour
{
    public AudioSource Music;
    public AudioSource Explosion;
    public float musictiming = 0;
    public static musicscript Instance;
    public bool explosion = false;
    // Start is called before the first frame update
    void Start()
    {
        Music.Play();
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        musictiming = Time.deltaTime;

        if (musictiming > 200)
        {
            Music.Play();
        }
        if (explosion ==true)
        {
            Explosion.Play();
            explosion = false;
        }
    }
}
