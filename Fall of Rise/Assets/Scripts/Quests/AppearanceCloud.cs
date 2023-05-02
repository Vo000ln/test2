using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceCloud : MonoBehaviour
{
    public bool zone = false;
    public GameObject notice;
    public bool for_one = true;
    public GameObject fadeIn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "PlayerMen" || other.tag == "PlayerWoman") && for_one)
        {
            zone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
        notice.SetActive(false);
    }

    private void Update()
    {
        if (zone)
        {
            notice.SetActive(true);
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && for_one)
        {
            zone = false; //закрываем доступ к зоне
            notice.SetActive(false); //делаем облако неактивным
            for_one = false; //чтобы в дальнейшем персонаж не мог тыкать на газету

            //(через мои любимые корутины)
            fadeIn.SetActive(true);
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(7);
        fadeIn.SetActive(false);
        //тут должен быть переход на новую сцену
    }
}
