using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject scoreUI;
    public GameObject highScoreUI;

	// Update is called once per frame
	void Update () {
        if (DataManagment.datamanagment.currentScore > DataManagment.datamanagment.highScore)
        {
            DataManagment.datamanagment.highScore = DataManagment.datamanagment.currentScore;
        }
        scoreUI.GetComponent<Text>().text = ("Score " + DataManagment.datamanagment.currentScore);
        highScoreUI.GetComponent<Text>().text = ("High Score " + DataManagment.datamanagment.highScore.ToString());
	}
}
