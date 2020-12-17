using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    public CountScene count;
    public NameController nameController;
    public Text levelTxt;
    public Text nameTxt;
    public string level;
    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.Find("CountScene").GetComponent<CountScene>();
        nameController = GameObject.Find("NameObj").GetComponent<NameController>();
        level = count.valueCountScene.ToString(level);
        Debug.Log(level);

        levelTxt.text = "Level : " + level;
        nameTxt.text = "Name : " + nameController.nameText;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
