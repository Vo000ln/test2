using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffCloudBeforeCab : MonoBehaviour
{
    public GameObject cloud_BeforeCab;
    public GameObject cloud_AfterCab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            cloud_BeforeCab.SetActive(false);
            cloud_AfterCab.SetActive(true);
        }
    }
}
