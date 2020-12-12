using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerContoller : MonoBehaviour
{
    public float timeRemaining = 100;
    public bool timerIsRunning = false;
    public bool timerIsPause = false;
    public Text timeText;
    public GameObject canvasTime;
    public CountScene countScene;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        canvasTime = GameObject.Find("Canvas2");
        canvasTime.SetActive(false);
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countScene.valueCountScene == 1)
        {
            timerIsRunning = true;
        }

        if (timerIsRunning)
        {
            if (!timerIsPause)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    Debug.Log("Time has run out!");
                    timeRemaining = 0;
                    timerIsRunning = false;
                    SceneManager.LoadScene(16);
                }
            }
            canvasTime.SetActive(true);
            DisplayTime(timeRemaining);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

