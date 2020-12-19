using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPanel : MonoBehaviour
{
    public GameObject credit;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void button()
    {
        credit.SetActive(true);
    }

    public void closeButton()
    {
        credit.SetActive(false);
    }


}
