using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentHostelStart : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject audio_source;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(17);
        fadeOut.SetActive(false);
        audio_source.SetActive(false);
        GameObject.Find("Telephone").GetComponent<AudioSource>().enabled = true;
    }
}