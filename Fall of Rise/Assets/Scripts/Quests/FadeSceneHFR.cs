using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSceneHFR : MonoBehaviour
{
    public GameObject o2;
    public GameObject Igor;
    public GameObject canvas_fade;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        canvas_fade.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Igor.GetComponent<SpriteRenderer>().enabled = false;
        Igor.GetComponent<BoxCollider2D>().enabled = false;
        o2.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSecondsRealtime(2);
        canvas_fade.SetActive(false);
    }
}
