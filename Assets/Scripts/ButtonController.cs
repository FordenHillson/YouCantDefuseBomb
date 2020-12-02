using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public BlueButton blueButton;
    public GreenButton greenButton;
    public OrangeButton orangeButton;

    public int resultButton;
    public int sizeArray;

    public GameObject[] ButtonArray;


    
    // Start is called before the first frame update
    void Start()
    {
        blueButton = GameObject.Find("Blue_Button").GetComponent<BlueButton>();
        greenButton = GameObject.Find("Green_Button").GetComponent<GreenButton>();
        orangeButton = GameObject.Find("Orange_Button").GetComponent<OrangeButton>();

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
        Debug.Log("Button is : "+resultButton);
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
            }
        }
    } 
    
}
