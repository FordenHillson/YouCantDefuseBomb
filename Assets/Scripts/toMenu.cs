using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMenu : MonoBehaviour
{
    
    public GameObject Count;    
    public GameObject nameObj;    
    //public GameObject timer;
    public GameObject song_1;
    public GameObject song_2;
    public GameObject soundTimer1;
    public GameObject soundTimer2;
    public GameObject soundTimer3;


    void Start()
    {
        Count = GameObject.Find("CountScene");        
        nameObj = GameObject.Find("NameObj");
        //timer = GameObject.Find("Canvas2");
        song_1 = GameObject.Find("song1");
        song_2 = GameObject.Find("song2");
        soundTimer1 = GameObject.Find("soundTimer1");
        soundTimer2 = GameObject.Find("soundTimer2");
        soundTimer3 = GameObject.Find("soundTimer3");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(Count.gameObject);        
        Destroy(nameObj.gameObject);        
        //Destroy(timer.gameObject);
        Destroy(song_1.gameObject);
        Destroy(song_2.gameObject);
        Destroy(soundTimer1.gameObject);
        Destroy(soundTimer2.gameObject);
        Destroy(soundTimer3.gameObject);

    }
}
