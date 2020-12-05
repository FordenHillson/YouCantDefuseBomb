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
                score++;
                orangeButton.isOrange = false;
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
                score++;
                lightBlueButton.isLightBlue = false;
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
                score++;
                whiteButton.isWhite = false;
            }
        }              
             
    }
}
