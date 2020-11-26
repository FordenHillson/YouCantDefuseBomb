using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RandomValueWire : MonoBehaviour
{

    public int resultWire;

    public YellowWire yellowWire;
    public BlueWire blueWire;
    public RedWire redWire;
    public WhiteWire whiteWire;    
    public int numNext = 0;

    public CountScene countScene;
    
    // Start is called before the first frame update
    void Start()
    {
        //yellowWire = GetComponent<YellowWire>();
        //blueWire = GetComponent<BlueWire>();
        //redWire = GetComponent<RedWire>();

        yellowWire = GameObject.Find("Yellow_Wire").GetComponent<YellowWire>();
        blueWire = GameObject.Find("Blue_Wire").GetComponent<BlueWire>();
        redWire = GameObject.Find("Red_Wire").GetComponent<RedWire>();
        whiteWire = GameObject.Find("White_Wire").GetComponent<WhiteWire>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
        
        if(countScene.valueCountScene <=5)
        {
            resultWire = Random.Range(1,3);
        }else if (countScene.valueCountScene > 5 & countScene.valueCountScene <= 10 )
        {
            resultWire = Random.Range(1,4);
        }

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

       if(whiteWire.isWhite)
       {
           
           if(whiteWire.WhiteValue == resultWire)
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
