using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngameHard : MonoBehaviour
{   
   [Header("Button manager : ")]
   public ButtonControllerHard button;

   [Header("Wire manager : ")] 
   public RandomValueWireHard valueWireHard;
   public CountScene countScene;
   
   public bool isWire1 = false;
   public bool isWire2 = false;

    [Header("Timer Manager : ")]
    public TimerContoller timer;

    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = true;
        valueWireHard = GameObject.Find("Wire").GetComponent<RandomValueWireHard>();
        button = GameObject.Find("Button").GetComponent<ButtonControllerHard>();

        
    }

    // Update is called once per frame
    void Update()
    {    
       if(isWire1 && isWire2)
       {
            SceneManager.LoadScene(14);
            timer.timeRemaining += 5;
            timer.timerIsRunning = false;
       } 

       if(button.score >= 14)
       {
            SceneManager.LoadScene(14);
            timer.timeRemaining += 5;
            timer.timerIsRunning = false;
       }
    }

    void loadScene()
    {
        
    }

}
