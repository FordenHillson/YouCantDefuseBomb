using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomController : MonoBehaviour
{
    public static int numberRND = 0;
    public static int ResultRndNumScene = 0;

    // Start is called before the first frame update
    public void Start()
    {
        numberRND = Random.Range(1,4);
        Debug.Log("Next Scene is : "+numberRND);
        numberRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void numberRandom()
    {
        ResultRndNumScene = numberRND;
        Debug.Log(ResultRndNumScene);
    }
}
