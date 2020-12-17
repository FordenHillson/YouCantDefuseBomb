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
    public NameController nameController;
    // Start is called before the first frame update
    void Start()
    {
        randomController = GameObject.Find("Randomnumber_OBJ").GetComponent<RandomController>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
        nameController = GameObject.Find("NameObj").GetComponent<NameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rndScene()
    {      
        numScene = RandomController.ResultRndNumScene;
        SceneManager.LoadScene(numScene);
        countScene.valueCountScene++;        
    }

    public void startScene()
    {
        if (nameController.nameField.text != "")
        {
            SceneManager.LoadScene(15);
            countScene.valueCountScene++;
        }
        else if (nameController.nameField.text == "")
        {
            nameController.warning.SetActive(true);
        }
    }
}
