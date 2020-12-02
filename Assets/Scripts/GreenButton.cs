using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public int greenValue = 2;
    public SpriteRenderer spriteGreen;
    private Sprite greenClickSprite;
    public bool isGreen = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteGreen = GetComponent<SpriteRenderer>();
        greenClickSprite = Resources.Load<Sprite>("Green_Button_isClick");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "Green_Button") {
                isGreen = true;
                spriteGreen.sprite = greenClickSprite;            
            }

        }
    }
}
