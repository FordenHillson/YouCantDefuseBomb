using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngame : MonoBehaviour
{
   

   [Header("Wire manager : ")]  
   public RandomValueWire valueWire;   
   public bool isWire1 = false;

   [Header("Button manager : ")]
   public ButtonController button;

   [Header("Timer Manager : ")]
   public TimerContoller timer;

    //int numScene;    
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = true;
        valueWire = GameObject.Find("Wire").GetComponent<RandomValueWire>();
        button = GameObject.Find("Button").GetComponent<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isWire1)
        {
            SceneManager.LoadScene(14);
            timer.timerIsRunning = false;
            timer.timeRemaining += 5;

        }        

        if(button.score >= 2)
        {
            SceneManager.LoadScene(14);
            timer.timerIsRunning = false;
            timer.timeRemaining += 5;

        }        

    }

}