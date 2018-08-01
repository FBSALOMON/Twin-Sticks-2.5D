using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public bool recording;

    private bool gamePause = false;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;
        } else
        {
            recording = true;
        }

        if (CrossPlatformInputManager.GetButtonDown("Pause") && !gamePause)
        {
            PauseGame();
        } else if (CrossPlatformInputManager.GetButtonDown("Pause") && gamePause)
        {
            ResumeGame();
        }
	}

    void PauseGame()
    {
        Time.timeScale = 0f;
        Time.fixedDeltaTime = 0f;
        gamePause = true;
    }
    void ResumeGame()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
        gamePause = false;
    }
    /*private void OnApplicationPause(bool pause)
    {
        gamePause = pause;
        PauseGame();
    }*/
}
