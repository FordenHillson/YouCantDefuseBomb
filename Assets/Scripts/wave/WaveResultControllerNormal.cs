using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveResultControllerNormal : MonoBehaviour
{
    public waveControllerNormal waveController;
    public Animator waveAnim;
    // Start is called before the first frame update
    void Start()
    {
        waveController = GameObject.Find("wave").GetComponent<waveControllerNormal>();
        waveAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waveControllerNormal.resultWave == 1)
        {
            waveAnim.SetInteger("WaveType", 1);
        }
        if (waveControllerNormal.resultWave == 2)
        {
            waveAnim.SetInteger("WaveType", 2);
        }
        if (waveControllerNormal.resultWave == 3)
        {
            waveAnim.SetInteger("WaveType", 3);
        }
        if (waveControllerNormal.resultWave == 4)
        {
            waveAnim.SetInteger("WaveType", 4);
        }
        if (waveControllerNormal.resultWave == 5)
        {
            waveAnim.SetInteger("WaveType", 5);
        }

        Debug.Log(waveControllerNormal.resultWave);
    }
}
