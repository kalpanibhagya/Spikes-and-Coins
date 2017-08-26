using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int Score = 0;
    public int Lives = 10;
    public Text TxtScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addScore() {
      Score++;
      TxtScore.text = Score.ToString();
      Debug.Log("Added one point" );
    }

    public void LooseLife() {
      
      Lives--;
     
      Debug.Log("Lost one life!!");
    }

    public void Restart() {
      Application.LoadLevel(Application.loadedLevel);

    }
}


//Adding scores and reducing lives 