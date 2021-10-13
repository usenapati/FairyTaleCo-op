using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a little credit to 
// One Wheel Studio: https://www.youtube.com/watch?v=YHC-6I_LSos
// samyam: https://www.youtube.com/watch?v=m5WsmlEOFiA
// great resources to help me get this up and running.

public class WitchController : MonoBehaviour

// controls variable
{
    private WitchInputActions witchControls;

    // exported variables

    public float movementSpeed = 5;
    public float jumpForce = 500;

    public bool facingRight = false;

    // private components

    private Animator anim;

    private Rigidbody2D r;

    // Start is called before the first frame update. Get components
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Debug.Log("Hi from Lix Control Script Start() method!");
    }

    // Input events

    private void Awake()
    {
        witchControls = new WitchInputActions();
    }

    private void OnEnable()
    {
        witchControls.Enable();
    }

    private void OnDisable()
    {
        witchControls.Disable();
    }

    private void Update()
    {
        Vector2 move_keys = witchControls.Player.Move.ReadValue<Vector2>();
        // Debug.Log(move);
        if (witchControls.Player.Jump.triggered)
        {
            Debug.Log("trix jump");
        }

        float movement = move_keys.x * Time.deltaTime * movementSpeed;

        if ((movement < 0 && facingRight) || (movement > 0 && !facingRight))
        {
            Flip();
        }

        transform.position += new Vector3(movement, 0, 0);

        anim.SetFloat("Speed", Mathf.Abs(movement));

        if (witchControls.Player.Jump.triggered && Mathf.Abs(r.velocity.y) < 0.001)
        {
            r.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
        }
        else if (Mathf.Abs(r.velocity.y) < 0.001)
        {
            anim.SetBool("IsJumping", false);
        }

        // Animation Demo
        if (witchControls.Animations.Dance.triggered)
        {
            anim.Play("Trix_Dance");
        }
        if (witchControls.Animations.Winner.triggered)
        {
            anim.Play("Trix_Winner");
        }
        if (witchControls.Animations.Loser.triggered)
        {
            anim.Play("Trix_Loser");
        }
    }

    void Flip()
    {
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;
        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
