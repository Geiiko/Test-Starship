using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {
    public int damagePerShot = 20;
    public float timeBetweenShots = 0.15f;
    public float range = 100f;
    public Camera turretCam;

    float timer;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(turretCam.transform.position, turretCam.transform.forward, out hit, range))
        {
            Enemyhealth target = hit.transform.GetComponent<Enemyhealth>();
            if (target != null)
            {
                target.TakeDamage(damagePerShot);
            }
        }
    }
}
