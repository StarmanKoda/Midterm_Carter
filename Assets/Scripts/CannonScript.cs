using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public float timer;
    public float fireeveryseconds;
    public GameObject objectemissionpoint;
    public GameObject Projectile;
    int timesshot = 0;
    public int shootlimit;
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Projectile, objectemissionpoint.transform.position, objectemissionpoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timesshot == shootlimit)
        {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }

        if (timer > fireeveryseconds)
        {
            timer = 0;
            if (timesshot != shootlimit -1)
            {
                Instantiate(Projectile, objectemissionpoint.transform.position, objectemissionpoint.transform.rotation);
                UnityEngine.Debug.Log("Shot");
            }
            timesshot += 1;
        }
    }
}
