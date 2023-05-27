using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject canvas_fadein;

    public void PlayGame()
    {
        StartCoroutine(Coroutine());
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator Coroutine()
    {
        canvas_fadein.SetActive(true);
        yield return new WaitForSecondsRealtime(1.9f);
        SceneManager.LoadScene("CutScene");
    }
}
