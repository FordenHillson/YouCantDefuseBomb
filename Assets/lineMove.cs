using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineMove : MonoBehaviour
{
    public Vector3 pointA = new Vector3(0, 1, 0);
    public Vector3 pointB = new Vector3(0, -1, 0);
    public float speed = 1;
    float t;

    public bool isArea = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;

        // Moves the object to target position
        transform.position = Vector3.Lerp(pointA, pointB, t);

        // Flip the points once it has reached the target
        if (t >= 1)
        {
            var b = pointB;
            var a = pointA;

            pointA = b;
            pointB = a;

            t = 0;
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isArea = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isArea = false;
    }

}
