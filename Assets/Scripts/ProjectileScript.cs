using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float speed;
    public float despawnTime;
    public ParticleSystem explosion;
    float timeAlive = 0;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        timeAlive += Time.deltaTime;

        if (timeAlive > despawnTime)
        {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        musicscript.Instance.explosion = true;
        Destroy(gameObject);
    }
}
