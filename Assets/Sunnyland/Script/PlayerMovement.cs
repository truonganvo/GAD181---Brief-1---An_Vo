using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float  MovementSpeed = 1f;
    public float JumpForce = 1f;

    private Rigidbody2D _rigidbody;
    public Animator animator;
    [SerializeField] AudioSource jumpingSound;

    private enum MovementState { idle, running, jumping, falling}
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        jumpingSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        MovementState state;
        //movement with transition & animation
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector2(-1, 1);
            state = MovementState.running;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector2(1, 1);
            state = MovementState.running;
        }
        else
        {
            state = MovementState.idle;
        }

        //jumping & animation
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            jumpingSound.Play();
        }
        if (_rigidbody.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (_rigidbody.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        animator.SetInteger("state", (int)state);
    }

}
