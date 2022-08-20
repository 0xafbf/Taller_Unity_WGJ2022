using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float speed = 5;

    public KeyCode KeyLeft  = KeyCode.A;
    public KeyCode KeyRight = KeyCode.D;
    public KeyCode KeyUp    = KeyCode.W;
    public KeyCode KeyDown  = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime;

        Vector3 desiredPosition = transform.position;

        if (Input.GetKey(KeyLeft))  desiredPosition.x -= distance;
        if (Input.GetKey(KeyRight)) desiredPosition.x += distance;
        if (Input.GetKey(KeyDown))  desiredPosition.y -= distance;
        if (Input.GetKey(KeyUp))    desiredPosition.y += distance;

        transform.position = desiredPosition;

    }
}
