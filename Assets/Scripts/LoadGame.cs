using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour {

    public void LoadToScene (int sceneToLoad)
    {
        Application.LoadLevel(sceneToLoad);
        playerMovement.playerSpeed = 15;
    }
}
