using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreMenuCanvas : MonoBehaviour
{
    public GameObject canvas_instruction;
    public GameObject audio;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(12);
        canvas_instruction.SetActive(false);
        audio.SetActive(true);
    }
}
