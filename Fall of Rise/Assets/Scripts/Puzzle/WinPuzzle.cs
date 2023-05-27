using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPuzzle : MonoBehaviour
{
    public GameObject canvas_win;
    public GameObject canvas_kotya;
    public GameObject canvas_fadefinish;

    void Update()
    {
        if (DataClass.count_elements == 12)
        {
            StartCoroutine(Coroutine());
            DataClass.count_elements = 0;
        }
    }

    IEnumerator Coroutine()
    {
        canvas_win.SetActive(true);
        yield return new WaitForSecondsRealtime(2.5f);
        canvas_kotya.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        canvas_win.SetActive(false);
        yield return new WaitForSecondsRealtime(2f);
        canvas_fadefinish.SetActive(true);
        yield return new WaitForSecondsRealtime(2.9f);
        //тут типо затемнение, еще один канвас
        SceneManager.LoadScene("EKZ_2");
    }
}
