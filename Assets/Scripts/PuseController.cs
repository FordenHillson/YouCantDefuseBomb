using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuseController : MonoBehaviour
{
    public GameObject pausePanel;
    public TimerContoller timer;

    public GameObject Count;
    public GameObject nameObj;
    public GameObject timerObj;
    public GameObject song_1;
    public GameObject song_2;

    public songsController songs;
    public song2Controller song2;

    
    public bool isTap = false;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel = GameObject.Find("Panel");
        pausePanel.SetActive(false);
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();

        Count = GameObject.Find("CountScene");
        nameObj = GameObject.Find("NameObj");
        timerObj = GameObject.Find("Canvas2");
        song_1 = GameObject.Find("song1");
        song_2 = GameObject.Find("song2");

        songs = GameObject.Find("song1").GetComponent<songsController>();
        song2 = GameObject.Find("song2").GetComponent<song2Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            if(!isTap)
            {                
                isTap = true;
                PauseOpen();
            }else if (Input.GetKeyDown("escape"))
            {
                if(isTap)
                {                    
                    isTap = false;
                    PauseResume();
                }
            }
        }
    }

    public void PauseOpen()
    {
        pausePanel.SetActive(true);
        timer.timerIsRunning = false;
        songs.song.volume= 0.1f;
        song2.song.volume= 0.1f;
    }

    public void PauseResume()
    {
        pausePanel.SetActive(false);
        timer.timerIsRunning = true;
        songs.song.volume = 0.5f;
        song2.song.volume = 0.5f;
    }

    public void PauseExit()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(Count.gameObject);
        Destroy(nameObj.gameObject);
        Destroy(timer.gameObject);
        Destroy(timerObj.gameObject);
        Destroy(song_1.gameObject);
        Destroy(song_2.gameObject);
        Destroy(this.gameObject);
        Destroy(pausePanel.gameObject);
    }
}
