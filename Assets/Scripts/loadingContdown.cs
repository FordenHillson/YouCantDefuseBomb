using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingContdown : MonoBehaviour
{
    public float time = 0;
    public float timeAmount;
    public float incTimePerSecond = 1;

    public RandomtoScene randomtoScene;
    // Start is called before the first frame update
    void Start()
    {
        randomtoScene = GameObject.Find("rndScene").GetComponent<RandomtoScene>();
    }

    // Update is called once per frame
    void Update()
    {
       time += incTimePerSecond * Time.deltaTime;
       if(time >= 1)
       {
           randomtoScene.rndScene();
       }   
    }
}
