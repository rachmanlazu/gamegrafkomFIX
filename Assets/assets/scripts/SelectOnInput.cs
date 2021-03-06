﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectObject;

    private bool buttonSelect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetAxisRaw("Vertical") != 0 && buttonSelect == false)
        {
            eventSystem.SetSelectedGameObject(selectObject);
            buttonSelect = true;
        }	
	}

    private void onDisable()
    {
        buttonSelect = false;
    }
}
