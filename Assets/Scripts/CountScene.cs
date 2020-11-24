using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountScene : MonoBehaviour
{
    public int valueCountScene = 0;
    
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        print ("Scene Count: " + SceneManager.sceneCountInBuildSettings);      
    }

    void Update()
    {
       Debug.Log("This scene is : " + valueCountScene);
    }

   
}
