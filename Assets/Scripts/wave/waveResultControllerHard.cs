using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveResultControllerHard : MonoBehaviour
{
    public waveControllerHard waveController;
    public Animator waveAnim;
    // Start is called before the first frame update
    void Start()
    {
        waveController = GameObject.Find("wave").GetComponent<waveControllerHard>();
        waveAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waveController.resultWave == 1)
        {
            waveAnim.SetInteger("WaveType", 1);
        }
        if (waveController.resultWave == 2)
        {
            waveAnim.SetInteger("WaveType", 2);
        }
        if (waveController.resultWave == 3)
        {
            waveAnim.SetInteger("WaveType", 3);
        }
        if (waveController.resultWave == 4)
        {
            waveAnim.SetInteger("WaveType", 4);
        }
        if (waveController.resultWave == 5)
        {
            waveAnim.SetInteger("WaveType", 5);
        }

        Debug.Log(waveController.resultWave);
    }
}

