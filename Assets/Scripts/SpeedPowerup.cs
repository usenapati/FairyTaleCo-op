using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{
    public GoblinController goblinController;
    public WitchController witchController;

    bool touched = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Potion Colliding!");
        if (collision.gameObject.tag == "Player" && !touched)
        {
            touched = true;

            //hide without disabling
            GetComponent<Renderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;

            Debug.Log("hid object, about to speed up");
            if (collision.gameObject.GetComponent<GoblinController>() != null)
            {
                Debug.Log("Calling coroutine");
                StartCoroutine("SpeedUpGoblin");
            } else 
            {
                Debug.Log("Calling Coroutine");
                StartCoroutine("SpeedUpWitch");
            }
        }
    }

    IEnumerator SpeedUpGoblin()
    {
        Debug.Log("Goblin Coroutine Called");
        goblinController.movementSpeed *= 2;
        witchController.movementSpeed /= 2;
        yield return new WaitForSecondsRealtime(15f);
        goblinController.movementSpeed /= 2;
        witchController.movementSpeed *= 2;
        Destroy(gameObject);
    }

    IEnumerator SpeedUpWitch()
    {
        Debug.Log("Witch Coroutine Called");
        goblinController.movementSpeed /= 2;
        witchController.movementSpeed *= 2;
        yield return new WaitForSecondsRealtime(15f);
        goblinController.movementSpeed *= 2;
        witchController.movementSpeed /= 2;
        Destroy(gameObject);
    }
}
