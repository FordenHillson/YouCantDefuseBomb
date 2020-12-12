using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitController : MonoBehaviour
{
    public lineMove line;
    public TimerContoller timer;

    // Start is called before the first frame update
    void Start()
    {   
        line = GameObject.Find("Line").GetComponent<lineMove>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = true;
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
            SceneManager.LoadScene(15);
            timer.timerIsRunning = false;
        }    
    }
}
