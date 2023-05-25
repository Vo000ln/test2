using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeVasyaRun : MonoBehaviour
{
    public GameObject canvas_vasyarun;
    public GameObject o2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        canvas_vasyarun.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        o2.GetComponent<SpriteRenderer>().enabled = false;
        o2.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSecondsRealtime(3);
        canvas_vasyarun.SetActive(false);
    }
}
