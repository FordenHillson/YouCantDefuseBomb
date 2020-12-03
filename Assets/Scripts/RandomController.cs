﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomController : MonoBehaviour
{
    public static int numberRND = 0;
    public static int ResultRndNumScene = 0;

    public CountScene countScene;

    // Start is called before the first frame update
    public void Start()
    {
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();

        randomSceneController();
        numberRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void numberRandom()
    {
        ResultRndNumScene = numberRND;
        Debug.Log(ResultRndNumScene);
    }

    public void randomSceneController()
    {
        if(countScene.valueCountScene <= 5)
        {
            numberRND = Random.Range(1,3);
        }else if(countScene.valueCountScene > 5 && countScene.valueCountScene <= 10)
        {
           numberRND = Random.Range(4,6); 
        }else if(countScene.valueCountScene > 10)
        {
            numberRND = Random.Range(7,9);
        }

        
        Debug.Log("Next Scene is : "+numberRND);
    }
}
