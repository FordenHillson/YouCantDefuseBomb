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
    public bool isBlueWrong;
    public bool isGreenWrong;
    public bool isOrangeWrong;
    public bool isLightblueWrong;
    public bool isWhiteWrong;
    public bool isPinkWrong;
    public bool isLightgreenWrong;
    public bool isPurpleWrong;
    public bool isYellowWrong;

    [Header("Timer : ")]
    public TimerContoller timer;

    [Header("result : ")]
    public int resultButton;
    public int resultButton2;
    

    [Header("Check : ")]
    public int score = 0;
    

    [Header("Array : ")]
    public int sizeArray;
    public GameObject[] ButtonArray;

    [Header("Button Sound : ")]
    public AudioSource corretSound;
    public AudioSource wrongSound;
    public bool blueSound;
    public bool greenSound;
    public bool orangeSound;
    public bool lightblueSound;
    public bool whiteSound;
    public bool pinkSound;
    public bool lightGreenSound;
    public bool purpleSound;
    public bool yellowSound;
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
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        blueSound = false;
        greenSound = false;
        orangeSound = false;
        lightblueSound = false;
        whiteSound = false;
        pinkSound = false;
        lightGreenSound = false;
        purpleSound = false;
        yellowSound = false;

        randomController();
    }

    // Update is called once per frame
    void Update()
    {
        checkResult();
        if (resultButton2 == resultButton)
        {
            resultButton2 = Random.Range(1, sizeArray += 1);
        }
    }

    void randomController()
    {
        sizeArray = ButtonArray.Length;
        resultButton = Random.Range(1,sizeArray += 1);
        resultButton2 = Random.Range(1,sizeArray += 1 );
        
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
                if (!blueSound)
                {
                    wrongSound.Play();
                    blueSound = true;
                }
                if (!isBlueWrong)
                {
                    timer.timeRemaining -= 10;
                    isBlueWrong = true;
                }
            }
            else if(blueButton.blueValue != resultButton && blueButton.blueValue == resultButton2)
            {
                score --;
                if (!blueSound)
                {
                    wrongSound.Play();
                    blueSound = true;
                }
                if (!isBlueWrong)
                {
                    timer.timeRemaining -= 10;
                    isBlueWrong = true;
                }
            }

            if(blueButton.blueValue != resultButton && blueButton.blueValue != resultButton2)
            {
                if (!blueSound)
                {
                    corretSound.Play();
                    blueSound = true;
                }
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
                if (!greenSound)
                {
                    corretSound.Play();
                    greenSound = true;
                }
            }

            if(greenButton.greenValue == resultButton && greenButton.greenValue != resultButton2)
            {
                score --;
                if (!greenSound)
                {
                    wrongSound.Play();
                    greenSound = true;
                }
                if (!isGreenWrong)
                {
                    timer.timeRemaining -= 10;
                    isGreenWrong = true;
                }
            }
            else if(greenButton.greenValue != resultButton && greenButton.greenValue == resultButton2)
            {
                score --;
                if (!greenSound)
                {
                    wrongSound.Play();
                    greenSound = true;
                }
                if (!isGreenWrong)
                {
                    timer.timeRemaining -= 10;
                    isGreenWrong = true;
                }
            }

            if (greenButton.greenValue != resultButton && greenButton.greenValue != resultButton2)
            {
                if (!greenSound)
                {
                    corretSound.Play();
                    greenSound = true;
                }
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
                if (!orangeSound)
                {
                    wrongSound.Play();
                    orangeSound = true;
                }
                if (!isOrangeWrong)
                {
                    timer.timeRemaining -= 10;
                    isOrangeWrong = true;
                }
            }
            else if(orangeButton.orangeValue != resultButton && orangeButton.orangeValue == resultButton2)
            {
                score --;
                if (!orangeSound)
                {
                    wrongSound.Play();
                    orangeSound = true;
                }
                if (!isOrangeWrong)
                {
                    timer.timeRemaining -= 10;
                    isOrangeWrong = true;
                }
            }

            if (orangeButton.orangeValue != resultButton && orangeButton.orangeValue != resultButton2)
            {
                if (!orangeSound)
                {
                    corretSound.Play();
                    orangeSound = true;
                }
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
                if (!lightblueSound)
                {
                    wrongSound.Play();
                    lightblueSound = true;
                }
                if (!isLightblueWrong)
                {
                    timer.timeRemaining -= 10;
                    isLightblueWrong = true;
                }
            }
            else if(lightBlueButton.lightBlueValue != resultButton && lightBlueButton.lightBlueValue == resultButton2)
            {
                score --;
                if (!lightblueSound)
                {
                    wrongSound.Play();
                    lightblueSound = true;
                }
                if (!isLightblueWrong)
                {
                    timer.timeRemaining -= 10;
                    isLightblueWrong = true;
                }
            }

            if (lightBlueButton.lightBlueValue != resultButton && lightBlueButton.lightBlueValue != resultButton2)
            {
                if (!lightblueSound)
                {
                    corretSound.Play();
                    lightblueSound = true;
                }
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
                if (!whiteSound)
                {
                    wrongSound.Play();
                    whiteSound = true;
                }
                if (!isWhiteWrong)
                {
                    timer.timeRemaining -= 10;
                    isWhiteWrong = true;
                }
            }
            else if(whiteButton.whiteValue != resultButton && whiteButton.whiteValue == resultButton2)
            {
                score --;
                if (!whiteSound)
                {
                    wrongSound.Play();
                    whiteSound = true;
                }
                if (!isWhiteWrong)
                {
                    timer.timeRemaining -= 10;
                    isWhiteWrong = true;
                }
            }

            if (whiteButton.whiteValue != resultButton && whiteButton.whiteValue != resultButton2)
            {
                if (!whiteSound)
                {
                    corretSound.Play();
                    whiteSound = true;
                }
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
                if (!pinkSound)
                {
                    wrongSound.Play();
                    pinkSound = true;
                }
                if (!isPinkWrong)
                {
                    timer.timeRemaining -= 10;
                    isPinkWrong = true;
                }
            }
            else if(pinkButton.PinkValue != resultButton && pinkButton.PinkValue == resultButton2)
            {
                score --;
                if (!pinkSound)
                {
                    wrongSound.Play();
                    pinkSound = true;
                }
                if (!isPinkWrong)
                {
                    timer.timeRemaining -= 10;
                    isPinkWrong = true;
                }

            }

            if (pinkButton.PinkValue != resultButton && pinkButton.PinkValue != resultButton2)
            {
                if (!pinkSound)
                {
                    corretSound.Play();
                    pinkSound = true;
                }
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
                if (!lightGreenSound)
                {
                    wrongSound.Play();
                    lightGreenSound = true;
                }
                if(!isLightgreenWrong)
                {
                    timer.timeRemaining -= 10;
                    isLightgreenWrong = true;
                }
            }
            else if(lightGreenButton.LightGreenValue != resultButton && lightGreenButton.LightGreenValue == resultButton2)
            {
                score --;
                if (!lightGreenSound)
                {
                    wrongSound.Play();
                    lightGreenSound = true;
                }
                if (!isLightgreenWrong)
                {
                    timer.timeRemaining -= 10;
                    isLightgreenWrong = true;
                }
            }

            if (lightGreenButton.LightGreenValue != resultButton && lightGreenButton.LightGreenValue != resultButton2)
            {
                if (!lightGreenSound)
                {
                    corretSound.Play();
                    lightGreenSound = true;
                }
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
                if (!purpleSound)
                {
                    wrongSound.Play();
                    purpleSound = true;
                }
                if(!isPurpleWrong)
                {
                    timer.timeRemaining -= 10;
                    isPurpleWrong = true;
                }
            }
            else if(purpleButton.PurpleValue != resultButton && purpleButton.PurpleValue == resultButton2)
            {
                score --;
                if (!purpleSound)
                {
                    wrongSound.Play();
                    purpleSound = true;
                }
                if (!isPurpleWrong)
                {
                    timer.timeRemaining -= 10;
                    isPurpleWrong = true;
                }
            }

            if (purpleButton.PurpleValue != resultButton && purpleButton.PurpleValue != resultButton2)
            {
                if (!purpleSound)
                {
                    corretSound.Play();
                    purpleSound = true;
                }
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
                if (!yellowSound)
                {
                    wrongSound.Play();
                    yellowSound = true;
                }
                if(!isYellowWrong)
                {
                    timer.timeRemaining -= 10;
                    isYellowWrong = true;
                }
            }
            else if(yellowButton.YellowValue != resultButton && yellowButton.YellowValue == resultButton2)
            {
                score --;
                if (!yellowSound)
                {
                    wrongSound.Play();
                    yellowSound = true;
                }
                if (!isYellowWrong)
                {
                    timer.timeRemaining -= 10;
                    isYellowWrong = true;
                }
            }

            if (yellowButton.YellowValue != resultButton && yellowButton.YellowValue != resultButton2)
            {
                if (!yellowSound)
                {
                    corretSound.Play();
                    yellowSound = true;
                }
            }
        }             
             
    }
}
