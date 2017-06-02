using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInit : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
        DataManagment.datamanagment.currentScore = 0;
        DataManagment.datamanagment.LoadData();
	}
	
}
