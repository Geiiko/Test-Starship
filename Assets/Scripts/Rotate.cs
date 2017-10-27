using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public float speed = 10.0F;
    public float RotSpeed = 150.0F;
    public float minY = -30.0f;
    public float maxY = 30.0f;
    public float minX = -90.0f;
    public float maxX = 90.0f;
    float forwardBackward;
    float leftRight;
    float RotLeftRight;
    float RotUpDown;
    Vector3 euler;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localEulerAngles = euler;
        // Getting axes
        forwardBackward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        leftRight = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        RotLeftRight = Input.GetAxis("Mouse X") * RotSpeed * Time.deltaTime;
        RotUpDown = (Input.GetAxis("Mouse Y") * -1) * RotSpeed * Time.deltaTime;

        // Doing movements
        transform.Translate(0, 0, forwardBackward);
        transform.Translate(leftRight, 0, 0);
        euler.y += RotLeftRight;

        euler.x += RotUpDown;

        //uncomment if you want y axis blocked
        /*if (euler.y >= maxY)
            euler.y = maxY;
        if (euler.y <= minY)
            euler.y = minY; */
        if (euler.x >= maxX)
            euler.x = maxX;
        if (euler.x <= minX)
            euler.x = minX;
    }
}
