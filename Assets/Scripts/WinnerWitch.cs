using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerWitch : MonoBehaviour
{

    public bool won;

    // Start is called before the first frame update
    void Start()
    {
        if (won)
        {
            GetComponent<Animator>().Play("Trix_Dance");
        }
        else
        {
            transform.SetPositionAndRotation(new Vector2(transform.position.x, transform.position.y - .15f), transform.rotation);
            GetComponent<Animator>().Play("Trix_Lose");
        }
            
    }
}
