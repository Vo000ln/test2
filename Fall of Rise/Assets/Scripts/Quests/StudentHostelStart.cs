using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentHostelStart : MonoBehaviour
{
    //public bool zone = false;
    public GameObject fadeOut;
    public GameObject telephone;

    //private void OnTriggerEnter2D(Collider2D other)
    //{

    //    if (other.tag == "Player")
    //    {
    //        zone = true;
    //        //Debug.Log("OBJ");
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    zone = false;
    //}

    void Start()
    {
        //telephone = GetComponent<AudioSource>();
        StartCoroutine(Coroutine()); //для ожидания и +- нормального перехода сцены
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(17); //длительность анимации
        fadeOut.SetActive(false); //отключаем анимацию
        GameObject.Find("Telephone").GetComponent<AudioSource>().enabled = true; //подрубаю звонок телефона
        //telephone.enabled = true;
        //DataClass.endDialogue = 0;
        //Application.LoadLevel("StudentHostel");
    }

    //void Update()
    //{
    //    if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.endDialogue == 1)
    //    {
    //        fadeIn.SetActive(true); //активируем анимацию
    //        StartCoroutine(Coroutine()); //для ожидания и +- нормального перехода сцены
    //    }
    //}

    //IEnumerator Coroutine()
    //{
    //    yield return new WaitForSecondsRealtime(2);
    //    DataClass.endDialogue = 0;
    //    Application.LoadLevel("StudentHostel");
    //}
}
