using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomValueWireHard : MonoBehaviour
{
  public int resultWire;
    public int resultWire2;


    public YellowWire yellowWire;
    public BlueWire blueWire;
    public RedWire redWire;
    public WhiteWire whiteWire;    
    

    public CountScene countScene;
    public RandomSceneIngameHard randomSceneIngameHard;

    void Awake()
    {
        resultWire = Random.Range(1, 4);
        resultWire2 = Random.Range(1, 4);
        if (resultWire2 == resultWire)
        {
            resultWire2 = Random.Range(1, 4);
            Debug.Log("Wire 2 is : " + resultWire2);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        yellowWire = GameObject.Find("Yellow_Wire").GetComponent<YellowWire>();
        blueWire = GameObject.Find("Blue_Wire").GetComponent<BlueWire>();
        redWire = GameObject.Find("Red_Wire").GetComponent<RedWire>();
        whiteWire = GameObject.Find("White_Wire").GetComponent<WhiteWire>();
        countScene = GameObject.Find("CountScene").GetComponent<CountScene>();
        randomSceneIngameHard = GameObject.Find("RndScene").GetComponent<RandomSceneIngameHard>();
    }

    // Update is called once per frame
    void Update()
    {
        

       if(yellowWire.isYellow)
       {
           
           if(yellowWire.YellowValue == resultWire)
           {              
                Debug.Log("Yes!");    
                randomSceneIngameHard.isWire1 = true;             
               
           }
           else
           {
               Debug.Log("No");
                              
           }

           if(yellowWire.YellowValue == resultWire2)
           {              
                Debug.Log("Yes!");              
                randomSceneIngameHard.isWire2 = true;            
               
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
              randomSceneIngameHard.isWire1 = true;
               
           }
           else
           {
               Debug.Log("No");           
               
           }

           if(blueWire.BlueValue == resultWire2)
           {              
              Debug.Log("Yes!");            
              randomSceneIngameHard.isWire2 = true;
               
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
               randomSceneIngameHard.isWire1 = true;               
           }
           else
           {
               Debug.Log("No");              
               
           }

           if(redWire.RedValue == resultWire2)
           {               
               Debug.Log("Yes!");
               randomSceneIngameHard.isWire2 = true;                            
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
               randomSceneIngameHard.isWire1 = true;               
           }
           else
           {
               Debug.Log("No");              
               
           }

           if(whiteWire.WhiteValue == resultWire2)
           {              
               Debug.Log("Yes!");             
               randomSceneIngameHard.isWire2 = true;               
           }
           else
           {
               Debug.Log("No");              
               
           }
       }   
         
    }

}
