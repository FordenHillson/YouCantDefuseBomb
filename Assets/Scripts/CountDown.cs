using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float time = 0;
    public float timeAmount;
    public float incTimePerSecond = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += incTimePerSecond * Time.deltaTime;
        if (time >= 1.1)
        {
            SceneManager.LoadScene(15);
        }
    }
}
