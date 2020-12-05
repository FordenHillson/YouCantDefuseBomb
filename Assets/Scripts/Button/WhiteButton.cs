using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteButton : MonoBehaviour
{
    public SpriteRenderer spriteWhite;
    private Sprite whiteClickSprite;
    public int whiteValue = 5;
    public bool isWhite = false;
    public Collider2D whiteCol;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteWhite = GetComponent<SpriteRenderer>();
        whiteClickSprite = Resources.Load<Sprite>("White_Button_isClick");
        whiteCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "White_Button") {
                isWhite = true;
                spriteWhite.sprite = whiteClickSprite; 
                whiteCol.enabled = false;           
            }
        }          

    }
}
