using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGreen_2Button : MonoBehaviour
{
    public SpriteRenderer spriteLightGreen;
    private Sprite LightGreenClickSprite;
    public int LightGreenValue = 7;
    public bool isLightGreen = false;
    public Collider2D lightGreenCol;
    // Start is called before the first frame update
    void Start()
    {
        spriteLightGreen = GetComponent<SpriteRenderer>();
        LightGreenClickSprite = Resources.Load<Sprite>("LightGreen2_Button_isClick");
        lightGreenCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "LightGreen2_Button") {
                isLightGreen = true;
                spriteLightGreen.sprite = LightGreenClickSprite;
                lightGreenCol.enabled = false;            
            }
        }
    }
}
