using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour {
    GameObject player;
    public float delayShoot = 1f;
    public int weaponValue = 10;

    HealthShip playerHealth;
    float timer;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<HealthShip>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer >= delayShoot)
        {
            Shoot();
        }
	}

    void Shoot ()
    {
        timer = 0f;

        if (playerHealth.actualLife > 0)
        {
            playerHealth.TakeDamage(weaponValue);
        }
    }
}
