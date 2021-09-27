using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5;
    public float jumpForce = 1;

    private Rigidbody2D r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(r.velocity.y) < 0.001)
        {
            r.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
