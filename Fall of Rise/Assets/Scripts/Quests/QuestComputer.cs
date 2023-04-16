using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestComputer : MonoBehaviour
{
    public bool zone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
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
        if (zone && Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("Computer");
        }
    }
}
