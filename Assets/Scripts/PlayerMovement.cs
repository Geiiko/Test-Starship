using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10f;

    Rigidbody shipRigidbody;
    Vector3 movement;

	// Use this for initialization
	void Start () {
        shipRigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        movement.Set(0, 0f, 1);

        movement = movement.normalized * speed * Time.deltaTime;
        shipRigidbody.MovePosition(transform.position + movement);
	}
}
