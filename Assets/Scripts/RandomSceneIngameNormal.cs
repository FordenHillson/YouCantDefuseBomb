using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngameNormal : MonoBehaviour
{
   [Header("Button manager : ")]
   public ButtonControllerNormal button;
   

   void Start()
    {          
       button = GameObject.Find("Button").GetComponent<ButtonControllerNormal>();
    }

    void Update()
    {
        if(button.score == 4)
        {
            SceneManager.LoadScene(10);
        }


    }
}
