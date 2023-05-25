using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionFromHostelTo14 : MonoBehaviour
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
        if (zone)
        {
            Application.LoadLevel("Frame_ekzamen");
        }
    }
}
