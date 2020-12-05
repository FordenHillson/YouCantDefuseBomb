using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeButton : MonoBehaviour
{
    public int orangeValue = 3;

    public SpriteRenderer spriteOrange;
    private Sprite orangeClickSprite;
    public bool isOrange = false;
    public Collider2D orangeCol;
    // Start is called before the first frame update
    void Start()
    {
        spriteOrange = GetComponent<SpriteRenderer>();
        orangeClickSprite = Resources.Load<Sprite>("Orange_Button_isClick");
        orangeCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "Orange_Button") {
                isOrange = true;
                spriteOrange.sprite = orangeClickSprite;
                orangeCol.enabled = false;            
            }

        }
    }
}
