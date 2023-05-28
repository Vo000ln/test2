using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitComputer2 : MonoBehaviour
{
    public void ExitScene()
    {
        DataClass.choose_conversation_igor = 1;
        DataClass.off_cloud_hfr = true;
        DataClass.off_cloud_igor = true;
        if (DataClass.gender == "M")
            SceneManager.LoadScene("HostelForRun");
        else
            SceneManager.LoadScene("WomanHostelForRun");
    }
}
