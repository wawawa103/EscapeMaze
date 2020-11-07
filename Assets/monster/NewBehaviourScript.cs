using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rgb;
    CapsuleCollider2D col;
    public GameObject fire;
    public GameObject sprite;
    Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        col = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = fire.transform.position - transform.position;
        speed /= Vector3.Distance(fire.transform.position, transform.position);
        rgb.velocity = 2 * speed;
        col.isTrigger = true;
        if ( Vector2.Distance( transform.position , fire.transform.position ) <= 7f )
        {
            sprite.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            col.isTrigger = false;
        }else sprite.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
