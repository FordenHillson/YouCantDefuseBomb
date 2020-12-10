using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveControllerHard : MonoBehaviour
{
    public int resultWave;
    public int resultWave2;
    // Start is called before the first frame update
    void Start()
    {
        resultWave = Random.Range(1, 6);
        resultWave2 = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
