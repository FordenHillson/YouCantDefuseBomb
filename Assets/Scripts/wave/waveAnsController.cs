using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class waveAnsController : MonoBehaviour
{
    public Slider waveSlider;
    public float waveAnsValue;
    public Animator waveAnsAnim;
    public int waveAns;
    public AudioSource corretSound;
    public AudioSource wrongSound;


    public TimerContoller timer;

    // Start is called before the first frame update
    void Start()
    {
        waveSlider = GameObject.Find("Slider").GetComponent<Slider>();
        waveAnsAnim = GetComponent<Animator>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = true;
        corretSound = GetComponent<AudioSource>();
        wrongSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        waveAnsValue = waveSlider.value;

        if (waveAnsValue >= 1)
        {
            waveAnsAnim.SetInteger("WaveType", 1);
            waveAns = 1;
        }
        if(waveAnsValue >= 2)
        {
            waveAnsAnim.SetInteger("WaveType", 2);
            waveAns = 2;
        }
        if (waveAnsValue >= 3)
        {
            waveAnsAnim.SetInteger("WaveType", 3);
            waveAns = 3;
        }
    }

    public void AnsButton()
    {
        if(waveAns == waveController.resultWave)
        {
            SceneManager.LoadScene(15);
            timer.timerIsRunning = false;
            timer.timeRemaining += 5;
            corretSound.Play();
        }
        else
        {
            wrongSound.Play();
            timer.timeRemaining -= 5;
        }
        
    }
}
