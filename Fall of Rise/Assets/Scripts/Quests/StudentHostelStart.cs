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
        yield return new WaitForSecondsRealtime(18); //ждем определенное количество времени
        fadeOut.SetActive(false); //выключаем заставку
        GameObject.Find("Telephone").GetComponent<AudioSource>().enabled = true; //звонок по телефоену
    }
}