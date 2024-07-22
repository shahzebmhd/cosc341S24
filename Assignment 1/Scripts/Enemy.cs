using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 2.0f;
    public float minX = -5.0f;
    public float maxX = 5.0f;
    private float direction = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveBall();
        
    }

    void moveBall() {
        //move the ball
        Vector3 position = transform.position;
        position.x += direction * speed * Time.deltaTime;

        if (position.x >= maxX)
        {
            position.x = maxX;
            direction *= -1.0f;
        }
        else if (position.x <= minX) {
            position.x = minX;
            direction *= -1.0f;

        }
        transform.position = position;


    }
}
