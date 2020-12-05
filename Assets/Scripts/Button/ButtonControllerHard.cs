using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerHard : MonoBehaviour
{
    [Header("ButtonScripts : ")]
    public BlueButton blueButton;
    public GreenButton greenButton;
    public OrangeButton orangeButton;
    public LightBlueButton lightBlueButton;
    public WhiteButton whiteButton;
    public PinkButton pinkButton;
    public LightGreen_2Button lightGreenButton;
    public PurpleButton purpleButton;
    public YellowButton yellowButton;

    [Header("result : ")]
    public int resultButton;
    public int resultButton2;
    

    [Header("Check : ")]
    public int score = 0;
    

    [Header("Array : ")]
    public int sizeArray;
    public GameObject[] ButtonArray;
    // Start is called before the first frame update
    void Start()
    {
        blueButton = GameObject.Find("Blue_Button").GetComponent<BlueButton>();
        greenButton = GameObject.Find("Green_Button").GetComponent<GreenButton>();
        orangeButton = GameObject.Find("Orange_Button").GetComponent<OrangeButton>();
        lightBlueButton = GameObject.Find("LightBlue_Button").GetComponent<LightBlueButton>();
        whiteButton = GameObject.Find("White_Button").GetComponent<WhiteButton>();
        pinkButton = GameObject.Find("Pink_Button").GetComponent<PinkButton>();
        lightGreenButton = GameObject.Find("LightGreen2_Button").GetComponent<LightGreen_2Button>();
        purpleButton = GameObject.Find("Purple_Button").GetComponent<PurpleButton>();
        yellowButton = GameObject.Find("Yellow_Button").GetComponent<YellowButton>();

        randomController();
    }

    // Update is called once per frame
    void Update()
    {
        checkResult(); 
    }

    void randomController()
    {
        sizeArray = ButtonArray.Length;
        resultButton = Random.Range(1,sizeArray);
        resultButton2 = Random.Range(1,sizeArray);
        if(resultButton2 == resultButton)
        {
            resultButton2 = Random.Range(1,sizeArray);
        }
        Debug.Log("Button1 is : "+resultButton);
        Debug.Log("Button2 is : "+resultButton2);
    }

    void checkResult()
    {
        if(blueButton.isBlue)
        {
            if(blueButton.blueValue == resultButton)
            {
                Debug.Log("Boom");                                            
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                blueButton.isBlue = false;                                               
            }
            
            if(blueButton.blueValue == resultButton2)
            {
                Debug.Log("Boom");                                            
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                blueButton.isBlue = false;                                               
            }

            if(blueButton.blueValue == resultButton && blueButton.blueValue != resultButton2)
            {
                score --;
            }else if(blueButton.blueValue != resultButton && blueButton.blueValue == resultButton2)
            {
                score --;
            }
        }

        if(greenButton.isGreen)
        {
            if(greenButton.greenValue == resultButton)
            {
                Debug.Log("Boom");                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                greenButton.isGreen = false;
            }

            if(greenButton.greenValue == resultButton2)
            {
                Debug.Log("Boom");                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                greenButton.isGreen = false;
            }

            if(greenButton.greenValue == resultButton && greenButton.greenValue != resultButton2)
            {
                score --;
            }else if(greenButton.greenValue != resultButton && greenButton.greenValue == resultButton2)
            {
                score --;
            }
        }
        

        if(orangeButton.isOrange)
        {
            if(orangeButton.orangeValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                orangeButton.isOrange = false;
            }

            if(orangeButton.orangeValue == resultButton2)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                orangeButton.isOrange = false;
            }

            if(orangeButton.orangeValue == resultButton && orangeButton.orangeValue != resultButton2)
            {
                score --;
            }else if(orangeButton.orangeValue != resultButton && orangeButton.orangeValue == resultButton2)
            {
                score --;
            }
        }


        if(lightBlueButton.isLightBlue)
        {
            if(lightBlueButton.lightBlueValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                lightBlueButton.isLightBlue = false;
            }

            if(lightBlueButton.lightBlueValue == resultButton2)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                lightBlueButton.isLightBlue = false;
            }

            if(lightBlueButton.lightBlueValue == resultButton && lightBlueButton.lightBlueValue != resultButton2)
            {
                score --;
            }else if(lightBlueButton.lightBlueValue != resultButton && lightBlueButton.lightBlueValue == resultButton2)
            {
                score --;
            }
        }
        

        if(whiteButton.isWhite)
        {
            if(whiteButton.whiteValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                whiteButton.isWhite = false;
            }

            if(whiteButton.whiteValue == resultButton2)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                whiteButton.isWhite = false;
            }

            if(whiteButton.whiteValue == resultButton && whiteButton.whiteValue != resultButton2)
            {
                score --;
            }else if(whiteButton.whiteValue != resultButton && whiteButton.whiteValue == resultButton2)
            {
                score --;
            }
        }  

        if(pinkButton.isPink)
        {
            if(pinkButton.PinkValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                pinkButton.isPink = false;
            }

            if(pinkButton.PinkValue == resultButton2)
            {
                Debug.Log("Boom");                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                pinkButton.isPink = false;  
            }

            if(pinkButton.PinkValue == resultButton && pinkButton.PinkValue != resultButton2)
            {
                score --;
            }else if(pinkButton.PinkValue != resultButton && pinkButton.PinkValue == resultButton2)
            {
                score --;
            }
        }

        if(lightGreenButton.isLightGreen)
        {
            if(lightGreenButton.LightGreenValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                lightGreenButton.isLightGreen = false;
            }

            if(lightGreenButton.LightGreenValue == resultButton2)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                lightGreenButton.isLightGreen = false;  
            }

            if(lightGreenButton.LightGreenValue == resultButton && lightGreenButton.LightGreenValue != resultButton2)
            {
                score --;
            }else if(lightGreenButton.LightGreenValue != resultButton && lightGreenButton.LightGreenValue == resultButton2)
            {
                score --;
            }
        }
        
        if(purpleButton.isPurple)
        {
            if(purpleButton.PurpleValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                purpleButton.isPurple = false;
            }

            if(purpleButton.PurpleValue == resultButton2)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                purpleButton.isPurple = false;  
            }

            if(purpleButton.PurpleValue == resultButton && purpleButton.PurpleValue != resultButton2)
            {
                score --;
            }else if(purpleButton.PurpleValue != resultButton && purpleButton.PurpleValue == resultButton2)
            {
                score --;
            }
        }

        if(yellowButton.isYellow)
        {
            if(yellowButton.YellowValue == resultButton)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                yellowButton.isYellow = false;
            }

            if(yellowButton.YellowValue == resultButton2)
            {
                Debug.Log("Boom");
                
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                yellowButton.isYellow = false;  
            }

            if(yellowButton.YellowValue == resultButton && yellowButton.YellowValue != resultButton2)
            {
                score --;
            }else if(yellowButton.YellowValue != resultButton && yellowButton.YellowValue == resultButton2)
            {
                score --;
            }
        }             
             
    }
}
