using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveControllerNormal : MonoBehaviour
{
    public static int resultWave;
    // Start is called before the first frame update
    void Start()
    {
        resultWave = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
