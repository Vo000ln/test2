using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeImage : MonoBehaviour
{
    //смена изображений
    public GameObject image_1;
    public GameObject image_2;
    public GameObject image_3;
    public GameObject image_4;
    public GameObject image_5;

    //звук
    public GameObject audio;

    //затемнение на конец сцены
    public GameObject canvas_fadeout;

    void Start()
    {
        StartCoroutine(Coroutine_ChangeImage());
    }

    IEnumerator Coroutine_ChangeImage()
    {
        audio.SetActive(true);
        image_1.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        image_1.SetActive(false);
        image_2.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        image_2.SetActive(false);
        image_3.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        image_3.SetActive(false);
        image_4.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        image_4.SetActive(false);
        image_5.SetActive(true);
        yield return new WaitForSecondsRealtime(9);
        image_5.SetActive(false);
        canvas_fadeout.SetActive(true);
        yield return new WaitForSecondsRealtime(2.9f); //фейд
        //переход на сцену меню..............................
        SceneManager.LoadScene("Menu");
    }
}
