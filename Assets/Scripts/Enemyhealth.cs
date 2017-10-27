using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealth : MonoBehaviour {
    public int startLife = 100;
    public int actualLife;
    ParticleSystem hitParticles;

    bool isDead;
    bool damaged;

    // Use this for initialization
    void Start()
    {
        actualLife = startLife;
//hitParticles = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        damaged = false;
    }

    public void TakeDamage(int weaponValue/*, Vector3 hitPosition*/)
    {
        damaged = true;
        actualLife -= weaponValue;
        //hitParticles.transform.position = hitPosition;
        hitParticles.Play();
        if (actualLife <= 0 && !isDead)
        {
            //do what happen when target dies
            Destroy(gameObject);
        }
    }
}
