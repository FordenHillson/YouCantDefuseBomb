using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMenu : MonoBehaviour
{
    
    public GameObject Count;    
    public GameObject nameObj;    
    public GameObject timer;

    void Start()
    {
        Count = GameObject.Find("CountScene");        
        nameObj = GameObject.Find("NameObj");
        timer = GameObject.Find("Canvas2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(Count.gameObject);        
        Destroy(nameObj.gameObject);        
        Destroy(timer.gameObject);

    }
}
