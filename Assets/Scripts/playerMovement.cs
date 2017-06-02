using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public static float playerSpeed = 15;

    //public static float acceleration = 2f;
    //public static float maxSpeed = 60.0f;

    // Update is called once per frame
    void FixedUpdate () {

        //gameObject.transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);

        //playerSpeed += acceleration * Time.deltaTime;

        //if (playerSpeed > maxSpeed)
        //    playerSpeed = maxSpeed;

       gameObject.transform.Translate(Vector3.right * playerSpeed * Time.fixedDeltaTime);
	}
}
