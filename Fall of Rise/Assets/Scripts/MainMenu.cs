using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        if(DataClass.scene.Length == 0)
            SceneManager.LoadScene("CutScene");
        else{
            SceneManager.LoadScene(DataClass.scene);
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
