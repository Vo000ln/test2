using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentHostelStart : MonoBehaviour
{
    public GameObject fadeOut;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(17);
        fadeOut.SetActive(false);
        GameObject.Find("Telephone").GetComponent<AudioSource>().enabled = true;
    }
}