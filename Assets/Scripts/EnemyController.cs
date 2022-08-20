using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 4;
    public Rigidbody2D body;

    HeroController heroe;
    // Start is called before the first frame update
    void Start()
    {
        //heroe = FindObjectOfType<HeroController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (heroe != null) { 
            Vector3 deltaPos = heroe.transform.position - this.transform.position;

            Vector3 direccion = deltaPos.normalized;

            Vector3 velocidad = speed * direccion;

            Vector3 nuevaPosicion = this.transform.position;
            nuevaPosicion += velocidad * Time.deltaTime;
            body.MovePosition(nuevaPosicion);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("arstars");
        HeroController target = collision.collider.GetComponent<HeroController>();
        if (target)
        {
            if (target.health > 0) { 
                target.OnDamageReceive(1);
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HeroController target = collision.GetComponent<HeroController>();
        if (target)
        {
            if (target.health > 0) { 
                heroe = target;
            }
        }
    }
}
