using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckScore : MonoBehaviour
{
    [Header("waveResultController")]
    public waveControllerHard waveController;

    [Header("waveAnswerController")]
    public waveAnsControllerHard waveAns;
    public waveAns2ControllerHard waveAns2;

    [Header("Check")]
    public bool isWave1 = false;
    public bool isWave2 = false;

    [Header("Timer : ")]
    public TimerContoller timer;

    // Start is called before the first frame update
    void Start()
    {
        waveController = GameObject.Find("wave").GetComponent<waveControllerHard>();
        waveAns = GameObject.Find("Wave_Answer").GetComponent<waveAnsControllerHard>();
        waveAns2 = GameObject.Find("Wave_Answer2").GetComponent<waveAns2ControllerHard>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isWave1 && isWave2)
        {
            Debug.Log("Pass !");
            timer.timeRemaining += 5;
            SceneManager.LoadScene(15);
            timer.timerIsRunning = false;
        }
    }

    public void CheckWave1()
    {
        if(waveAns.waveAns == waveController.resultWave)
        {
            Debug.Log("wave 1 is corret");
            isWave1 = true;
        }
        else
        {
            Debug.Log("wave 1 is incorret");
        }        
    }
    public void CheckWave2()
    {
        if (waveAns2.waveAns == waveController.resultWave2)
        {
            Debug.Log("wave 2 is corret");
            isWave2 = true;
        }
        else
        {
            Debug.Log("wave 2 is incorret");
        }
    }

}
