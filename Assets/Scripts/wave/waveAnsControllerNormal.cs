using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class waveAnsControllerNormal : MonoBehaviour
{
    public Slider waveSlider;
    public float waveAnsValue;
    public Animator waveAnsAnim;
    public int waveAns;
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
            waveAns = 1;
        }
        if (waveAnsValue >= 2)
        {
            waveAnsAnim.SetInteger("WaveType", 2);
            waveAns = 2;
        }
        if (waveAnsValue >= 3)
        {
            waveAnsAnim.SetInteger("WaveType", 3);
            waveAns = 3;
        }
        if (waveAnsValue >= 4)
        {
            waveAnsAnim.SetInteger("WaveType", 4);
            waveAns = 4;
        }
        if (waveAnsValue >= 5)
        {
            waveAnsAnim.SetInteger("WaveType", 5);
            waveAns = 5;
        }
    }

    public void AnsButton()
    {
        if (waveAns == waveControllerNormal.resultWave)
        {
            SceneManager.LoadScene(15);
        }
    }
}
