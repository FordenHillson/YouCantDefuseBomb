using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingContdown : MonoBehaviour
{
    public float time = 0;
    public float timeAmount;
    public float incTimePerSecond = 1;

    public RandomtoScene randomtoScene;
    public TimerContoller timer;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        randomtoScene = GameObject.Find("rndScene").GetComponent<RandomtoScene>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        timer.timerIsRunning = false;
        canvas = GameObject.Find("Canvas2");
    }

    // Update is called once per frame
    void Update()
    {
        canvas.SetActive(false);
       time += incTimePerSecond * Time.deltaTime;
       if(time >= 1.3)
       {
           randomtoScene.rndScene();
       }   
    }
}
