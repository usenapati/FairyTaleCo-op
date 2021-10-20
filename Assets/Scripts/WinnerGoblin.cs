using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerGoblin : MonoBehaviour
{
    public bool won;

    // Start is called before the first frame update
    void Start()
    {
        if (won)
        {
            transform.SetPositionAndRotation(new Vector2(transform.position.x, transform.position.y - .275f), transform.rotation);
            GetComponent<Animator>().Play("Lix_Dance");
        }
        else
        {
            transform.SetPositionAndRotation(new Vector2(transform.position.x, transform.position.y - .25f), transform.rotation);
            GetComponent<Animator>().Play("Lix_Loser");
        }
    }
}
