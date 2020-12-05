using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleButton : MonoBehaviour
{
    public SpriteRenderer spritePurple;
    private Sprite PurpleClickSprite;
    public int PurpleValue = 8;
    public bool isPurple = false;
    // Start is called before the first frame update
    void Start()
    {
        spritePurple = GetComponent<SpriteRenderer>();
        PurpleClickSprite = Resources.Load<Sprite>("Purple_Button_isClick");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "Purple_Button") {
                isPurple = true;
                spritePurple.sprite = PurpleClickSprite;            
            }
        }       
    }
}
