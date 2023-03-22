using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestComputer : MonoBehaviour
{
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.name == "Player")
    //    {
    //        Update();
    //    }
    //}

    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        Application.LoadLevel("Computer");
    //    }
    //}

    //public void OnTriggerEnter2D(Collider2D other)  //near zone npc - open
    //{
    //    if (other.name == "Player")
    //    {
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            Application.LoadLevel("Computer");
    //        }
    //    }
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    print("Collision detected");
    //}

    public bool zone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем кто вошел в телепорт, игрок?
        if (other.tag == "Player")
        {
            zone = true;
            Debug.Log("OBJ");
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
