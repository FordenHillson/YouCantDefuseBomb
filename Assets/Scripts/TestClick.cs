using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestClick : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse Click");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            {
               if(Physics.Raycast(ray, out hit, 10f))
               {
                   Debug.Log("phy.raycast");
                   if(hit.transform != null)
                   {
                       Printname(hit.transform.gameObject);
                       //Debug.Log("hit.tranfrom");
                   }
               } 
            }
        }
    }

    private void Printname (GameObject go)
    {
        print(go.name);
    }
    
    
}
