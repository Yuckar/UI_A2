﻿using UnityEngine;
using System.Collections;

public class SettingsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void returnToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
