using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveAnsController : MonoBehaviour
{
    public Slider waveSlider;
    public float waveAnsValue;
    public Animator waveAnsAnim;
    // Start is called before the first frame update
    void Start()
    {
        waveSlider = GameObject.Find("Slider").GetComponent<Slider>();
        waveAnsAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        waveAnsValue = waveSlider.value;

        if (waveAnsValue >= 1)
        {
            waveAnsAnim.SetInteger("WaveType", 1);
        }
        if(waveAnsValue >= 2)
        {
            waveAnsAnim.SetInteger("WaveType", 2);
        }
        if (waveAnsValue >= 3)
        {
            waveAnsAnim.SetInteger("WaveType", 3);
        }
    }
}
