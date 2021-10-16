using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LixController : MonoBehaviour
{
    public float movementSpeed = 5;
    public float jumpForce = 1;

    public bool facingRight = false;

    private Animator anim;

    private Rigidbody2D r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Debug.Log("Hi from Lix Control Script Start() method!");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float movement = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;

        if ((movement < 0 && facingRight) || (movement > 0 && !facingRight))
        {
            Flip();
        }

        transform.position += new Vector3(movement, 0, 0);

        anim.SetFloat("Speed", Mathf.Abs(movement));

        if (Input.GetButtonDown("Jump") && Mathf.Abs(r.velocity.y) < 0.001)
        {
            r.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
        }
        else if (Mathf.Abs(r.velocity.y) < 0.001)
        {
            anim.SetBool("IsJumping", false);
        }


        // Animation Demo
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            anim.Play("Lix_Dance");
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            anim.Play("Lix_Winner");
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            anim.Play("Lix_Loser");
        }
        */
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

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("Lix is moving!");
    }
}
