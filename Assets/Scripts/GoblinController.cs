using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : MonoBehaviour

    // controls variable
{
    private GoblinInputActions goblinControls;

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
        goblinControls = new GoblinInputActions();
    }

    private void OnEnable()
    {
        goblinControls.Enable();
    }

    private void OnDisable()
    {
        goblinControls.Disable();
    }

    private void Update()
    {
        Vector2 move_keys = goblinControls.Player.Move.ReadValue<Vector2>();
        // Debug.Log(move);
        if (goblinControls.Player.Jump.triggered)
        {
            Debug.Log("lix jump");
        }

        float movement = move_keys.x * Time.deltaTime * movementSpeed;

        if ((movement < 0 && facingRight) || (movement > 0 && !facingRight))
        {
            Flip();
        }

        transform.position += new Vector3(movement, 0, 0);

        anim.SetFloat("Speed", Mathf.Abs(movement));

        if (goblinControls.Player.Jump.triggered && Mathf.Abs(r.velocity.y) < 0.001)
        {
            r.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
        }
        else if (Mathf.Abs(r.velocity.y) < 0.001)
        {
            anim.SetBool("IsJumping", false);
        }

        // Animation Demo
        if (goblinControls.Animations.Dance.triggered)
        {
            anim.Play("Lix_Dance");
        }
        if (goblinControls.Animations.Winner.triggered)
        {
            anim.Play("Lix_Winner");
        }
        if (goblinControls.Animations.Loser.triggered)
        {
            anim.Play("Lix_Loser");
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
