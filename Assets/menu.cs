using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void LoadLevel(int val) {
    Application.LoadLevel(val); //for move to next screen
  }
}


//this the welcome screen