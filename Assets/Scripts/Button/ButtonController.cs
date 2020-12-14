using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [Header("ButtonScripts : ")]
    public BlueButton blueButton;
    public GreenButton greenButton;
    public OrangeButton orangeButton;
    
    
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

    // Start is called before the first frame update
    void Start()
    {
        blueButton = GameObject.Find("Blue_Button").GetComponent<BlueButton>();
        greenButton = GameObject.Find("Green_Button").GetComponent<GreenButton>();
        orangeButton = GameObject.Find("Orange_Button").GetComponent<OrangeButton>();
        blueSound = false;
        greenSound = false;
        orangeSound = false;

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
                if(!blueSound)
                {
                    wrongSound.Play();
                    blueSound = true;
                }
            }
            else
            {
                Debug.Log("Ok");
                score ++;
                blueButton.isBlue = false;
                if(!blueSound)
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
        
             
    } 
    
}
