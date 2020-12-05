using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteWire : MonoBehaviour
{
    public int WhiteValue = 4;
    public bool isWhite = false;
    public Animator whiteWire;
    // Start is called before the first frame update
    void Start()
    {
       whiteWire = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                Debug.Log(hit.collider.gameObject.name);
                
            }

            if(hit.collider.name == "White_Wire")
            {
               isWhite = true;
               whiteWire.SetBool("isCut",true); 
            }

        }
    }
}
