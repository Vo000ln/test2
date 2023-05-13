using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceHdAndD : MonoBehaviour
{
    public GameObject head_department;
    public GameObject dean;
    public GameObject canvas;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(1);
        head_department.SetActive(true);
        dean.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        canvas.SetActive(false);
    }
}
