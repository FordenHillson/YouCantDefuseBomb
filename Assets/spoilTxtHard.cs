using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spoilTxtHard : MonoBehaviour
{
    public RandomValueWireHard wireHard;
    public Text txt1;
    public Text txt2;
    // Start is called before the first frame update
    void Start()
    {
        wireHard = GameObject.Find("Wire").GetComponent<RandomValueWireHard>();
        txt1 = GameObject.Find("Text").GetComponent<Text>();
        txt2 = GameObject.Find("Text2").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt1.text = "wire 1 " + wireHard.resultWire;
        txt2.text = "wire 2 " + wireHard.resultWire2;
    }
}
