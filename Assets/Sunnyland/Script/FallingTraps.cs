using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTraps : MonoBehaviour
{
    Rigidbody2D rb;
    PolygonCollider2D boxCollider2D;
    public float distance;
    bool isFalling = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<PolygonCollider2D>();

    }

    private void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if (isFalling == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance);

            Debug.DrawRay(transform.position, Vector2.down * distance, Color.red);

            if (hit.transform != null)
            {
                if(hit.transform.tag == "Player")
                {
                    rb.gravityScale = 5;
                    isFalling = true;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Level")
        {
            rb.gravityScale = 0;
            boxCollider2D.enabled = false;
        }
    }
}
