﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    public SpriteRenderer spriteBlue;
    private Sprite blueClickSprite;
    public int blueValue = 1;
    public bool isBlue = false;
    public Collider2D blueCol;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteBlue = GetComponent<SpriteRenderer>();
        blueClickSprite = Resources.Load<Sprite>("Blue_Button_isClick");
        blueCol = GetComponent<Collider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                        
            if (hit.collider.name == "Blue_Button") 
            {
                isBlue = true;                
                spriteBlue.sprite = blueClickSprite;  
                blueCol.enabled = false;                      
            }
        }         

    }
}
