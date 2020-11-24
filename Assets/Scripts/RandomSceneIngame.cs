﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngame : MonoBehaviour
{
   public GameObject numberScene;
   public RandomValueWire valueWire;
   public CountScene countScene;
    int numScene;
    // Start is called before the first frame update
    void Start()
    {
        numberScene = GameObject.Find("Randomnumber_OBJ");
        numberScene.GetComponent<RandomController>();

        valueWire = GameObject.Find("Wire").GetComponent<RandomValueWire>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(valueWire.numNext == 1)
        {
            rndScene();
            
        }
    }

    public void rndScene()
    {
        numScene = RandomController.ResultRndNumScene;
        SceneManager.LoadScene(numScene);
        countScene.valueCountScene ++;
    }
}
