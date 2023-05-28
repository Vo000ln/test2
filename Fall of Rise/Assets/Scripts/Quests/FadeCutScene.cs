using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeCutScene : MonoBehaviour
{
    public GameObject canvas_fadeout;
    public GameObject canvas_fadein;

    bool once = true;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    void Update()
    {
        if (DataClass.trans_on && once)
        {
            once = false;
            StartCoroutine(Coroutine2());
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(1);
        canvas_fadeout.SetActive(false);
    }

    IEnumerator Coroutine2()
    {
        canvas_fadein.SetActive(true);
        yield return new WaitForSecondsRealtime(1.9f);
        if (DataClass.gender == "M")
            SceneManager.LoadScene("HomePlayer");
        else
            SceneManager.LoadScene("WomanHomePlayer");
    }
}
