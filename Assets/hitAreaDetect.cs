using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitAreaDetect : MonoBehaviour
{
    public Collider2D hitArea;
    
    // Start is called before the first frame update
    void Start()
    {
        hitArea = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit : " + collision.gameObject.name);
    }
}
