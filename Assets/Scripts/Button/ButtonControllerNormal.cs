using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerNormal : MonoBehaviour
{
   [Header("ButtonScripts : ")]
    public BlueButton blueButton;
    public GreenButton greenButton;
    public OrangeButton orangeButton;
    public LightBlueButton lightBlueButton;
    public WhiteButton whiteButton;
    public PinkButton pinkButton;
    public bool isBlueWrong;
    public bool isGreenWrong;
    public bool isOrangeWrong;
    public bool isLightblueWrong;
    public bool isWhiteWrong;
    public bool isPinkWrong;

    [Header("Timer : ")]
    public TimerContoller timer;

    [Header("result : ")]
    public int resultButton;

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


    // Start is called before the first frame update
    void Start()
    {
        blueButton = GameObject.Find("Blue_Button").GetComponent<BlueButton>();
        greenButton = GameObject.Find("Green_Button").GetComponent<GreenButton>();
        orangeButton = GameObject.Find("Orange_Button").GetComponent<OrangeButton>();
        lightBlueButton = GameObject.Find("LightBlue_Button").GetComponent<LightBlueButton>();
        whiteButton = GameObject.Find("White_Button").GetComponent<WhiteButton>();
        pinkButton = GameObject.Find("Pink_Button").GetComponent<PinkButton>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        blueSound = false;
        greenSound = false;
        orangeSound = false;
        lightblueSound = false;
        whiteSound = false;
        pinkSound = false;

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
        resultButton = Random.Range(1,sizeArray += 1);
        Debug.Log("Button is : "+resultButton);
    }

    void checkResult()
    {
        if(blueButton.isBlue)
        {
            if(blueButton.blueValue == resultButton)
            {
                Debug.Log("Boom");
                if (!blueSound)
                {
                    wrongSound.Play();
                    blueSound = true;
                }
                if(!isBlueWrong)
                {
                    timer.timeRemaining -= 5;
                    isBlueWrong = true;
                }
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                blueButton.isBlue = false;
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
                if (!greenSound)
                {
                    wrongSound.Play();
                    greenSound = true;
                }
                if(!isGreenWrong)
                {
                    timer.timeRemaining -= 5;
                    isGreenWrong = true;
                }
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
        }

        if(orangeButton.isOrange)
        {
            if(orangeButton.orangeValue == resultButton)
            {
                Debug.Log("Boom");
                if (!orangeSound)
                {
                    wrongSound.Play();
                    orangeSound = true;
                }
                if(!isOrangeWrong)
                {
                    timer.timeRemaining -= 5;
                    isOrangeWrong = true;
                }
            }
            else
            {
                Debug.Log("Ok");
                score++;
                orangeButton.isOrange = false;
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
                if(!lightblueSound)
                {
                    wrongSound.Play();
                    lightblueSound = true;
                }
                if(!isLightblueWrong)
                {
                    timer.timeRemaining -= 5;
                    isLightblueWrong = true;
                }
            }
            else
            {
                Debug.Log("Ok");
                score++;
                lightBlueButton.isLightBlue = false;
                if(!lightblueSound)
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
                if (!whiteSound)
                {
                    wrongSound.Play();
                    whiteSound = true;
                }
                if(!isWhiteWrong)
                {
                    timer.timeRemaining -= 5;
                    isWhiteWrong = true;
                }
            }
            else
            {
                Debug.Log("Ok");
                score++;
                whiteButton.isWhite = false;
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
                if (!pinkSound)
                {
                    wrongSound.Play();
                    pinkSound = true;
                }
                if(!isPinkWrong)
                {
                    timer.timeRemaining -= 5;
                    isPinkWrong = true;
                }
            }
            else
            {
                Debug.Log("Ok");
                score++;
                pinkButton.isPink = false;
                if (!pinkSound)
                {
                    corretSound.Play();
                    pinkSound = true;
                }
            }            
        }              
             
    } 
}
