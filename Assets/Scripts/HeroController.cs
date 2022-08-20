using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float speed = 5;
    public int health = 3;


    public KeyCode KeyLeft  = KeyCode.A;
    public KeyCode KeyRight = KeyCode.D;
    public KeyCode KeyUp    = KeyCode.W;
    public KeyCode KeyDown  = KeyCode.S;

    public Rigidbody2D body;
    public Animator miAnimacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = speed * Time.deltaTime;

        Vector3 desiredMovement = new Vector3(0,0,0);

        if (Input.GetKey(KeyLeft))  desiredMovement.x -= distance;
        if (Input.GetKey(KeyRight)) desiredMovement.x += distance;
        if (Input.GetKey(KeyDown))  desiredMovement.y -= distance;
        if (Input.GetKey(KeyUp))    desiredMovement.y += distance;

        
        body.MovePosition(transform.position + desiredMovement);

    }

    public void OnDamageReceive(int amount)
    {
        
        this.health -= amount;
        if (health <= 0)
        {
            miAnimacion.Play("AnimDie");
        }
    }
}
