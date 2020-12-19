using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class song2Controller : MonoBehaviour
{
    public AudioClip phase2_song;
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

    void play()
    {
        if (timer.timeRemaining <= 30)
        {
            song.clip = phase2_song;
            if (!song.isPlaying)
            {
                song.Play();
                song.UnPause();
                song.volume = 0.5f;
            }
        }

        if (timer.timeRemaining >= 31)
        {
            song.Pause();
        }

        if (timer.timeRemaining <= 0)
        {
            song.Stop();
        }

    }
}
