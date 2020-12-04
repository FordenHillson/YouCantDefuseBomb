using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkButton : MonoBehaviour
{
     public SpriteRenderer spritePink;
    private Sprite PinkClickSprite;
    public int PinkValue = 6;
    public bool isPink = false;

    
    // Start is called before the first frame update
    void Start()
    {
        spritePink = GetComponent<SpriteRenderer>();
        PinkClickSprite = Resources.Load<Sprite>("Pink_Button_isClick");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "Pink_Button") {
                isPink = true;
                spritePink.sprite = PinkClickSprite;            
            }
        }           

    }
}
