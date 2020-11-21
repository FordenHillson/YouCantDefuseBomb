using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWire : MonoBehaviour
{
    public int YellowValue = 1;
    public bool isYellow = false;
    public Animator yellowWire;
    // Start is called before the first frame update
    void Start()
    {
        yellowWire = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("a"))
       {
           isYellow = true;
           yellowWire.SetBool("isCut",true);
       } 
    }
}
