﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngameNormal : MonoBehaviour
{
   [Header("Button manager : ")]
   public ButtonControllerNormal button;

    [Header("Timer manager : ")]
    public TimerContoller timer;
    void Start()
    {          
       button = GameObject.Find("Button").GetComponent<ButtonControllerNormal>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timer
    }

    void Update()
    {
        if(button.score == 4)
        {
            SceneManager.LoadScene(15);
        }


    }
}
