﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewMenuUI
{
    Button play;

    public ViewMenuUI()
    {
        play = GameObject.FindGameObjectWithTag("PlayButton").GetComponent<Button>();
        play.gameObject.SetActive(true);
        
    }

    public void DestroyUI()
    {
        play.gameObject.SetActive(false);
    }
    public void DisplayUI()
    {
        play.gameObject.SetActive(true);
    }
}
