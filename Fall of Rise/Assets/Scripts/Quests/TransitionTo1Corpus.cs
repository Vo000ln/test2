using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTo1Corpus : MonoBehaviour
{
    public bool zone = false;
    public GameObject fadeIn;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            zone = true;
            //Debug.Log("OBJ");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
    }

    void Update()
    {
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.endDialogue == 1)
        {
            fadeIn.SetActive(true); //активируем анимацию
            StartCoroutine(Coroutine()); //для ожидания и +- нормального перехода сцены
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(2);
        DataClass.endDialogue = 0;
        Application.LoadLevel("StudentHostel");
    }

}
