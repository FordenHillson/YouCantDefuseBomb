using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowButton : MonoBehaviour
{
    public SpriteRenderer spriteYellow;
    private Sprite YellowClickSprite;
    public int YellowValue = 9;
    public bool isYellow = false;
    public Collider2D yellowCol;
    // Start is called before the first frame update
    void Start()
    {
        spriteYellow = GetComponent<SpriteRenderer>();
        YellowClickSprite = Resources.Load<Sprite>("Yellow_Button_isClick");
        yellowCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "Yellow_Button") {
                isYellow = true;
                spriteYellow.sprite = YellowClickSprite;
                yellowCol.enabled = false;            
            }
        }
    }
}
