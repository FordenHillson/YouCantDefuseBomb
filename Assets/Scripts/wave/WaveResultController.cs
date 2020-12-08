using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveResultController : MonoBehaviour
{
    public waveController waveController;
    public Animator waveAnim;
    // Start is called before the first frame update
    void Start()
    {
        waveController = GameObject.Find("Wave").GetComponent<waveController>();
        waveAnim = GetComponent<Animator>();       
    }

    // Update is called once per frame
    void Update()
    {
        if(waveController.resultWave == 1)
        {
            waveAnim.SetInteger("WaveType",1);
        }
        if(waveController.resultWave == 2)
        {
            waveAnim.SetInteger("WaveType",2);
        }
        if(waveController.resultWave == 3)
        {
            waveAnim.SetInteger("WaveType",3);
        }
        Debug.Log(waveController.resultWave);
    }
}
