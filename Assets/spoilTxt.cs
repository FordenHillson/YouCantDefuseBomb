using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spoilTxt : MonoBehaviour
{
    public Text txt;
    public RandomValueWire wire;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        wire = GameObject.Find("Wire").GetComponent<RandomValueWire>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Wire is " + wire.resultWire;
    }
}
