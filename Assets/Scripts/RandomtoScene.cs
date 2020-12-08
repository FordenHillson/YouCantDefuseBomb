using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomtoScene : MonoBehaviour
{
    [Header("Scene manager : ")] 
    public RandomController randomController;
    public CountScene countScene;
    int numScene;
    // Start is called before the first frame update
    void Start()
    {
        randomController = GameObject.Find("Randomnumber_OBJ").GetComponent<RandomController>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rndScene()
    {
        numScene = RandomController.numberRND;
        SceneManager.LoadScene(numScene);
        countScene.valueCountScene ++;
        
    }
}
