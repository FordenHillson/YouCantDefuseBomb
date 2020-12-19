using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerContoller : MonoBehaviour
{
    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    public bool isBoom = false;
    public Text timeText;
    public Text levelText;
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
        
        if (countScene.valueCountScene == 0)
        {
            timerIsRunning = true;
        }

        if (timerIsRunning)
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
               SceneManager.LoadScene(17);               
               Destroy(this.gameObject);
               Destroy(canvasTime.gameObject);
            }                      
            canvasTime.SetActive(true);            
            DisplayTime(timeRemaining);
        }
        if(!timerIsRunning)
        {
            timeText.text = "";
            levelText.text = "";
        }        
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        levelText.text = "Level : " + countScene.valueCountScene.ToString();
    }
}

