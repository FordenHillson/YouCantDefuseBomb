using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomValueWire : MonoBehaviour
{
    public int resultWire;

    public YellowWire yellowWire;
    public BlueWire blueWire;
    public RedWire redWire;

    

    public int numNext = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //yellowWire = GetComponent<YellowWire>();
        //blueWire = GetComponent<BlueWire>();
        //redWire = GetComponent<RedWire>();

        yellowWire = GameObject.Find("Yellow_Wire").GetComponent<YellowWire>();
        blueWire = GameObject.Find("Blue_Wire").GetComponent<BlueWire>();
        redWire = GameObject.Find("Red_Wire").GetComponent<RedWire>();

        resultWire = Random.Range(1,3);
        Debug.Log("Wire is : "+resultWire);        
    }

    // Update is called once per frame
    void Update()
    {
       if(yellowWire.isYellow)
       {
           
           if(yellowWire.YellowValue == resultWire)
           {
               Debug.Log("Yes!");
                
                numNext = 1;
                
           }
           else
           {
               Debug.Log("No");
               
               
           }
       }

       if(blueWire.isBlue)
       {
           
           if(blueWire.BlueValue == resultWire)
           {
               Debug.Log("Yes!");
              
               numNext = 1;
               
           }
           else
           {
               Debug.Log("No");
              
               
           }
       }  
       
       if(redWire.isRed)
       {
           
           if(redWire.RedValue == resultWire)
           {
               Debug.Log("Yes!");
             
               numNext = 1;
               
           }
           else
           {
               Debug.Log("No");
               
               
           }
       }  
         
    }

    
    

}
