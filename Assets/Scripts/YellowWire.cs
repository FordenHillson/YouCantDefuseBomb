using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWire : MonoBehaviour
{
    public int YellowValue = 1;
    public bool isYellow = false;
    public Animator yellowWire;
    // Start is called before the first frame update
    void Start()
    {
        yellowWire = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("a"))
       {
           isYellow = true;
           yellowWire.SetBool("isCut",true);
       } 

       if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                Debug.Log(hit.collider.gameObject.name);
                
            }

            if(hit.collider.name == "Yellow_Wire")
            {
               isYellow = true;
               yellowWire.SetBool("isCut",true); 
            }

        }
    }
}
