using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// a little credit to 
// One Wheel Studio: https://www.youtube.com/watch?v=YHC-6I_LSos
// samyam: https://www.youtube.com/watch?v=m5WsmlEOFiA
// great resources to help me get this up and running.

public class WitchController : MonoBehaviour

    // controls variable
{
    private WitchInputActions witchControls;

    // constants
    private static int GRAB_LAYER = 3;
    private static string GRAB_TAG = "Grabbable";
    private static string GRAB_TAG_ALT = "Food";

    // exported variables

    public float movementSpeed = 5;
    public float jumpForce = 5;

    public bool facingRight = false;
    public bool holdingObject = false;

    public float maxGrabDistance = 2;
    public float minGrabDistance = 0.38F;

    // grab object
    private GameObject heldObject = null;

    // private components

    private Animator anim;

    private Rigidbody2D r;

    // Start is called before the first frame update. Get components
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Debug.Log("Hi from Trix Control Script Start() method!");
    }


    // Event handlers
    private void Grab(InputAction.CallbackContext context)
    {
        Debug.Log("Grab!");
        context.ReadValue<float>();

        if (heldObject == null)
        {
            // check for direction
            Vector2 dir = Vector2.left;
            if (facingRight) { dir = Vector2.right; }

            RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, maxGrabDistance, GRAB_LAYER);

            // check if it hit
            if (hit.collider != null && (hit.collider.tag == GRAB_TAG || hit.collider.tag == GRAB_TAG_ALT))
            {
                float distance = Mathf.Abs(hit.point.x - transform.position.x);

                Debug.Log("Trix is about to grab: " + hit.collider.name + " at distance " + distance);
                heldObject = hit.collider.gameObject;
                heldObject.transform.parent = transform;
                heldObject.GetComponent<Rigidbody2D>().isKinematic = true;
                // TODO: ADD Offset to make box not stick in player
            }
            else
            {
                Debug.Log("No grabby.");
            }
        }
        else
        {
            // ungrab
            Debug.Log("Trix let go the: " + heldObject.name);
            heldObject.transform.SetParent(null);
            heldObject.GetComponent<Rigidbody2D>().isKinematic = false;
            heldObject = null;

        }

    }


    // Input events

    private void Awake()
    {
        witchControls = new WitchInputActions();
    }

    private void OnEnable()
    {
        witchControls.Enable();

        // subscribe to event triggers
        witchControls.Player.Grab.performed += Grab;
    }

    private void OnDisable()
    {
        witchControls.Disable();

        // unsubscribe to event triggers
        witchControls.Player.Grab.performed -= Grab;
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
