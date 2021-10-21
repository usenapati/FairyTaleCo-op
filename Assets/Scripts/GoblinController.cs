using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GoblinController : MonoBehaviour

    // controls variable
{
    private GoblinInputActions goblinControls;

    // constants
    private static int GRAB_LAYER = 3;

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
        Debug.Log("Hi from Lix Control Script Start() method!");

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
            if (hit.collider != null)
            {
                float distance = Mathf.Abs(hit.point.x - transform.position.x);
                
                Debug.Log("Lix is about to grab: " + hit.collider.name + " at distance " + distance);
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
            Debug.Log("Lix let go the: " + heldObject.name);
            heldObject.transform.SetParent(null);
            heldObject.GetComponent<Rigidbody2D>().isKinematic = false;
            heldObject = null;
            
        }

    }



    // Input events

    private void Awake()
    {
        goblinControls = new GoblinInputActions();
    }

    private void OnEnable()
    {
        goblinControls.Enable();

        // subscribe to event triggers
        goblinControls.Player.Grab.performed += Grab;
    }

    private void OnDisable()
    {
        goblinControls.Disable();

        // unsubscribe from event triggers to prevent memleaks
        goblinControls.Player.Grab.performed -= Grab;
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

        // Put box with player




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
