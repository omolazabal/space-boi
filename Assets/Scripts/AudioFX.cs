using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFX : MonoBehaviour {

    public AudioClip death, jetPack, coinsCollect;

    bool playAudio = false;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump") && playerControls.jetPackFuel >= .001f) // check vars
        {
            GetComponent<AudioSource>().PlayOneShot(jetPack, .75f);
            if (playAudio)
            {
                GetComponent<AudioSource>().PlayOneShot(jetPack, .75f);
                playAudio = false;
            }
        } 
	}
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Enemy")// check vars
        {
            GetComponent<AudioSource>().PlayOneShot(death, 1.0f);
        }
    }
     void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Coin") // check vars
        {
            GetComponent<AudioSource>().PlayOneShot(coinsCollect, 1.0f);
        }
      
    }
}
