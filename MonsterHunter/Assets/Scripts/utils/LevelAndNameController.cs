﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelAndNameController : MonoBehaviour {

    private Text showText;

    // Use this for initialization
    void Start () {
        showText = GetComponent<Text>();
    }
	
    // Update is called once per frame
    void Update () {
        showText.text = "LV" + GameSettings.playerLevel + "\n" + GameSettings.username;
    }
}