using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveController : MonoBehaviour
{
    public static int resultWave;
    // Start is called before the first frame update
    void Start()
    {
        resultWave = Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
