using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountScene : MonoBehaviour
{
    public int valueCountScene = -1;
    //public toMenu menu;
    
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        print ("Scene Count: " + SceneManager.sceneCountInBuildSettings);      
    }

    void Start()
    {
        //menu = GameObject.Find("ToMainMenu").GetComponent<toMenu>();    
    }

    void Update()
    {
       Debug.Log("This scene is : " + valueCountScene);
        /*if(menu.isReStart)
        {
            Destroy(this.gameObject);
        }*/
    }

   
}
