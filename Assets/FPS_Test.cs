﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "FPS: " + 1.0f / Time.deltaTime;
        Debug.Log("??:"+ 1.0f / Time.deltaTime);
    }
}
