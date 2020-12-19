using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTimer : MonoBehaviour
{
    
    public AudioSource song;
    public TimerContoller timer;    
    // Start is called before the first frame update
    void Start()
    {
        song = GetComponent<AudioSource>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
    }

    // Update is called once per frame
    void Update()
    {
        play();
    }

    public void play()
    {     
       if (timer.timeRemaining <= 119)
       {          
          if (!song.isPlaying)
          {
              song.Play();
              song.volume = 0.6f;
          }
       }
        if (timer.timeRemaining <= 30)
        {
            song.Pause();
        }

        if(timer.timeRemaining >= 31)
        {
            if (!song.isPlaying)
            {
                song.UnPause();
            }
        }
        
    }
}
