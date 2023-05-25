using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudOgoVasya : MonoBehaviour
{
    public GameObject cloud_OgoVasya;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            cloud_OgoVasya.SetActive(true);
        }
    }

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    zone = false;
    //}
}
