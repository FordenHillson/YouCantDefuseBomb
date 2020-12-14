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
    

    public CountScene countScene;
    public RandomSceneIngame randomSceneIngame;

    public TimerContoller timer;

    public AudioSource corretSound;
    public AudioSource wrongSound;

    public bool yellowSound;
    public bool blueSound;
    public bool redSound;
    public bool whiteSound;

    void Awake()
    {
        resultWire = Random.Range(1, 4);
    }

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
        randomSceneIngame = GameObject.Find("RndScene 1").GetComponent<RandomSceneIngame>();
        timer = GameObject.Find("Timer").GetComponent<TimerContoller>();
        corretSound = GameObject.Find("CorretSound").GetComponent<AudioSource>();
        wrongSound = GameObject.Find("WrongSound").GetComponent<AudioSource>();

        yellowSound = false;
        blueSound = false;
        redSound = false;
        whiteSound = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (yellowWire.isYellow)
        {

            if (yellowWire.YellowValue == resultWire)
            {
                Debug.Log("Yes!");

                randomSceneIngame.isWire1 = true;
                if (!yellowSound)
                {
                    corretSound.Play();
                    yellowSound = true;
                }
            }
            if(yellowWire.YellowValue != resultWire)
            {
                Debug.Log("No");
                if (!yellowSound)
                {
                    wrongSound.Play();
                    yellowSound = true;
                }
            }


        }

        if (blueWire.isBlue)
        {

            if (blueWire.BlueValue == resultWire)
            {
                Debug.Log("Yes!");
                randomSceneIngame.isWire1 = true;
                if (!blueSound)
                {
                    corretSound.Play();
                    blueSound = true;
                }
            }
            if (blueWire.BlueValue != resultWire)
            {
                Debug.Log("No");
                if (!blueSound)
                {
                    wrongSound.Play();
                    blueSound = true;
                }
            }

        }

        if (redWire.isRed)
        {

            if (redWire.RedValue == resultWire)
            {
                Debug.Log("Yes!");
                randomSceneIngame.isWire1 = true;
                if (!redSound)
                {
                    corretSound.Play();
                    redSound = true;
                }
            }
            if(redWire.RedValue != resultWire)
            {
                Debug.Log("No");
                if (!redSound)
                {
                    wrongSound.Play();
                    redSound = true;
                }


            }
        }

        if (whiteWire.isWhite)
        {
            if (whiteWire.WhiteValue == resultWire)
            {
                Debug.Log("Yes!");
                randomSceneIngame.isWire1 = true;
                if (!whiteSound)
                {
                    corretSound.Play();
                    whiteSound = true;
                }                
            }
            if (whiteWire.WhiteValue != resultWire)
            {
                Debug.Log("No");
                if (!whiteSound)
                {
                    wrongSound.Play();
                    whiteSound = true;
                }
            }
        }
    }

}

      

    


