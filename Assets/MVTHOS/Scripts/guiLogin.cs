﻿using UnityEngine;
using System.Collections;

public class guiLogin : MonoBehaviour {
	private string u = "username";
	private string p = "password";	

	private string usernameString = string.Empty;
	private string passwordString = string.Empty;

	private Rect windowRect = new Rect(0,0,Screen.width, Screen.height);

	// Use this for initialization
	void Start () {
	GUI.Window (0, windowRect, WindowFunction, "Login");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Window (0, windowRect, WindowFunction, "Log-in");
	}

	void WindowFunction (int windowID){


		usernameString = GUI.TextField 		(new Rect (Screen.width / 3, 2 * Screen.height / 5, Screen.width / 2, Screen.height / 10), usernameString, 10);
		passwordString = GUI.PasswordField 	(new Rect (Screen.width / 3, 2 * Screen.height / 3, Screen.width / 2, Screen.height / 10), passwordString, "*" [0], 10);
		if(GUI.Button (new Rect(Screen.width/2, 4 * Screen.height/5, Screen.width/8, Screen.height/8), "Log-in"))
		{
			if(usernameString == u && passwordString == p)
			{
				Debug.Log ("Welcome Drew");
			}
			else {Debug.Log ("Wrong username or password");}
		};

		GUI.Label (new Rect(Screen.width/3, 35 * Screen.height/100, Screen.width/5, Screen.height/8), "Username");
		GUI.Label (new Rect(Screen.width/3, 35 * Screen.height/100, Screen.width/5, Screen.height/8), "Password");
}
}