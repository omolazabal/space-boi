using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {

    public static float jetPackFuel = 10000000f;
    public float jetPackForce = 10.0f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump") && jetPackFuel >= 0.001f) {
            BoostUp();
        }
	}

    void BoostUp() {
        jetPackFuel = Mathf.MoveTowards(jetPackFuel, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody>().AddForce(new Vector3(0, jetPackForce));
    }

    void onCollisionEnter (Collision Col)
    {
        if (Col.gameObject.tag == "Ground")
        {
            jetPackFuel = 1.5f;
        }
    }
}
