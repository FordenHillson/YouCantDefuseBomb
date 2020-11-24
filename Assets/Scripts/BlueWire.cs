using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueWire : MonoBehaviour
{
    public  int BlueValue = 2;
    public  bool isBlue = false;

    public Animator blueWireAnim;
    // Start is called before the first frame update
    void Start()
    {
        blueWireAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
       {
           isBlue = true;
           blueWireAnim.SetBool("isCut",true);
       } 

       
       if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                Debug.Log(hit.collider.gameObject.name);
                
            }

            if(hit.collider.name == "Blue_Wire")
            {
               isBlue = true;
               blueWireAnim.SetBool("isCut",true); 
            }

        }
    }
}
