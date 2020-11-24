﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneController : MonoBehaviour
{
    public GameObject numberScene;
    public CountScene countScene;
    int numScene;
    // Start is called before the first frame update
    void Start()
    {
        numberScene = GameObject.Find("Randomnumber_OBJ");
        numberScene.GetComponent<RandomController>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rndScene()
    {
        numScene = RandomController.ResultRndNumScene;
        SceneManager.LoadScene(numScene);
        countScene.valueCountScene ++;      

    }
}
