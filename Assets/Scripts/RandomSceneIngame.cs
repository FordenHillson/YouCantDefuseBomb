using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngame : MonoBehaviour
{
   [Header("Scene manager : ")] 
   public GameObject numberScene;
   public CountScene countScene;

   [Header("Wire manager : ")]  
   public RandomValueWire valueWire;   
   public bool isWire1 = false;

   [Header("Button manager : ")]
   public ButtonController button;
   
   
    int numScene;
    // Start is called before the first frame update
    void Start()
    {
        numberScene = GameObject.Find("Randomnumber_OBJ");
        numberScene.GetComponent<RandomController>();

        valueWire = GameObject.Find("Wire").GetComponent<RandomValueWire>();        
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();

        button = GameObject.Find("Button").GetComponent<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isWire1 /*&& isWire2*/)
        {
            rndScene();
        }

        if(button.score == 2)
        {
            rndScene();
        }


    }

    public void rndScene()
    {
        numScene = RandomController.ResultRndNumScene;
        SceneManager.LoadScene(numScene);
        countScene.valueCountScene ++;
    }
}
