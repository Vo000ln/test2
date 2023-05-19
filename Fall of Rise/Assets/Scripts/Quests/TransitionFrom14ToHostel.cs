using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionFrom14ToHostel : MonoBehaviour
{
    public bool zone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
            //Debug.Log("OBJ");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
    }

    void Update()
    {
        if (zone && DataClass.endDialogue >= 3)
        {
            DataClass.endDialogue = 0;
            Application.LoadLevel("HostelforDialogue");
        }
    }
}
