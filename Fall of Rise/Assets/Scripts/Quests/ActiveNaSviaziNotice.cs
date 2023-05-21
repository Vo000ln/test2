using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNaSviaziNotice : MonoBehaviour
{
    public GameObject notice1;
    public GameObject notice2;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        notice1.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        notice2.SetActive(true);
    }

}
