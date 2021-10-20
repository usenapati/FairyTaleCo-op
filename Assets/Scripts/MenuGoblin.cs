using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGoblin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().Play("Lix_Winner");
    }
}
