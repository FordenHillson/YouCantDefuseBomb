using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlueButton : MonoBehaviour
{
    public SpriteRenderer spriteLightBlue;
    private Sprite lightBlueClickSprite;
    public int lightBlueValue = 4;
    public bool isLightBlue = false;
    public Collider2D lightblueCol;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteLightBlue = GetComponent<SpriteRenderer>();
        lightBlueClickSprite = Resources.Load<Sprite>("LightBlue_Button_isClick");
        lightblueCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "LightBlue_Button") {
                isLightBlue = true;
                spriteLightBlue.sprite = lightBlueClickSprite;
                lightblueCol.enabled = false;            
            }
        }

           

    }
}
