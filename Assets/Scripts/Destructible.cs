using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{

    public float velocityToDestroy;

    public GameObject prefabToSpawn;

    public GameObject destructionParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Velocity: " + collision.relativeVelocity.y);
            if (collision.relativeVelocity.y < velocityToDestroy)
            {
                if (prefabToSpawn != null)
                {
                    Instantiate(prefabToSpawn, transform.position, transform.rotation);
                }

                GameObject d = Instantiate(destructionParticles, transform.position, transform.rotation);
                
                d.GetComponent<ParticleSystem>().Play();

                Destroy(d, 0.5f);

                Destroy(gameObject);
            }
            
        }
    }
}
