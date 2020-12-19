using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitController : MonoBehaviour
{
    public lineMove line;
    public TimerContoller timer;
    public AudioSource corretSound;
    public AudioSource wrongSound;


    // Start is called before the first frame update
    void Start()
    {   
        line = GameObject.Find("Line").GetComponent<lineMove>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = true;
        corretSound = GetComponent<AudioSource>();
        wrongSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void hitButton()
    {
        if(line.isArea)
        {
            Debug.Log("pass");
            SceneManager.LoadScene(14);
            timer.timerIsRunning = false;
            timer.timeRemaining += 5;
            corretSound.Play();
        }
        else
        {
            Debug.Log("wave 1 is incorret");
            wrongSound.Play();
            timer.timeRemaining -= 10;
        }

    }
}
