using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRotation : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("highscore"));
    }

}
