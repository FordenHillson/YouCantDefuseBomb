using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songsController : MonoBehaviour
{
    public AudioClip phase1_song;    
    public AudioSource song;    
    public TimerContoller timer;
    

    // Start is called before the first frame update
    void Start()
    {
        song =  GetComponent<AudioSource>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();        
    }

    // Update is called once per frame
    void Update()
    {
        play();
    }

    void play()
    {
        if (timer.timeRemaining <= 119)
        {
            song.clip = phase1_song;
            if(!song.isPlaying)
            {
                song.Play();
            }
        }

        if(timer.timeRemaining <= 30)
        {
            song.Stop();
        }

        if(timer.timeRemaining >= 31)
        {
            if (!song.isPlaying)
            {
                song.Play();
            }
        }

       
    }
}
