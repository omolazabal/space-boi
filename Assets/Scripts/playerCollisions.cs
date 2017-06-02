using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerCollisions : MonoBehaviour {

    public GameObject restartUI;
    public GameObject quitUI;

    void OnCollisionEnter(Collision col)
    {
	        if (col.gameObject.tag == "Enemy")
    	    {
        	    PlayerDies();
        	}
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Coin")
        {
            DataManagment.datamanagment.coinsCollected++;
            DataManagment.datamanagment.currentScore++;
            //play audio effect
            Destroy(trigger.gameObject);
        }

    }

    void PlayerDies()
    {
        //play death audio
        DataManagment.datamanagment.SaveData();
        restartUI.gameObject.SetActive(true);
        quitUI.gameObject.SetActive(true);
        playerMovement.playerSpeed = 0;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<playerControls>().enabled = false;
    }

}
