﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{

    public Canvas kb, leader;
    string word = null;
    int wordIndex = 0;
    string alpha;
    public Text myName = null;

    private void Awake()
    {
        kb.enabled = false;
    }


    public void alphabetFunction(string alphabet)
    {
        wordIndex++;
        word = word + alphabet;
        myName.text = word;

    }



    public void enterFunction()
    {

    }
}
