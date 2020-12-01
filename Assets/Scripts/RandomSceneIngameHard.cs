using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneIngameHard : MonoBehaviour
{
  public GameObject numberScene;
   
   public RandomValueWireHard valueWireHard;
   public CountScene countScene;
   
   public bool isWire1 = false;
   public bool isWire2 = false;
   
    int numScene;
    // Start is called before the first frame update
    void Start()
    {
        numberScene = GameObject.Find("Randomnumber_OBJ");
        numberScene.GetComponent<RandomController>();

        
        valueWireHard = GameObject.Find("Wire").GetComponent<RandomValueWireHard>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isWire1 && isWire2)
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
