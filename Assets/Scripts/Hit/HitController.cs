using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitController : MonoBehaviour
{
    public lineMove line;
    
    // Start is called before the first frame update
    void Start()
    {
        line = GameObject.Find("Line").GetComponent<lineMove>();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }    

    public void hitButton()
    {
        if(line.isArea)
        {
            Debug.Log("pass");
            SceneManager.LoadScene(15);
        }    
    }
}
