using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play("Trix_Winner");
    }
}
