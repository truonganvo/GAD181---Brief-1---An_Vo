using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float  MovementSpeed = 1f;
    public float JumpForce = 1f;

    private Rigidbody2D _rigidbody;
    public Animator animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //movement with transition & animation
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector2(-1, 1);
            animator.SetBool("running", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector2(1, 1);
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }

        //jumping
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        
        
    }

}
