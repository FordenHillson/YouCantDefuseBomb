using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueWire : MonoBehaviour
{
    public  int BlueValue = 2;
    public  bool isBlue = false;

    public Animator blueWireAnim;
    // Start is called before the first frame update
    void Start()
    {
        blueWireAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
       {
           isBlue = true;
           blueWireAnim.SetBool("isCut",true);
       } 
    }
}
