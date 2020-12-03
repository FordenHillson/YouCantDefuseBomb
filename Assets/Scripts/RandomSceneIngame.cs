using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngame : MonoBehaviour
{
   

   [Header("Wire manager : ")]  
   public RandomValueWire valueWire;   
   public bool isWire1 = false;

   [Header("Button manager : ")]
   public ButtonController button;
   
   
    int numScene;
    // Start is called before the first frame update
    void Start()
    { 
       valueWire = GameObject.Find("Wire").GetComponent<RandomValueWire>();        
       button = GameObject.Find("Button").GetComponent<ButtonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isWire1 )
        {
            SceneManager.LoadScene(10);
        }

        if(button.score == 2)
        {
            SceneManager.LoadScene(10);
        }


    }

    
}