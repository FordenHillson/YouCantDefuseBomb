using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedWire : MonoBehaviour 
{
    public  int RedValue = 3;
    public  bool isRed = false;

    //public RandomValueWire resultWire;

    public Animator redWireAnim;
    // Start is called before the first frame update
    void Start()
    {
        redWireAnim = GetComponent<Animator>();

       // resultWire = GameObject.Find("Wire").GetComponent<RandomValueWire>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
       {
           isRed = true;
           redWireAnim.SetBool("isCut",true);
       } 

       if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                Debug.Log(hit.collider.gameObject.name);                               
            }

            if(hit.collider.name == "Red_Wire")
            {
               isRed = true;
               redWireAnim.SetBool("isCut",true); 
            }
            

            
        }
    }
}

    

    

