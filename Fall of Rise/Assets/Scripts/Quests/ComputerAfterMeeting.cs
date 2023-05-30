using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerAfterMeeting : MonoBehaviour
{
    public bool zone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
    }

    void Update()
    {
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.comp)
        {
            DataClass.off_cloud_hfr = true;
            DataClass.comp = false;
            Application.LoadLevel("Computer");
        }
    }
}
