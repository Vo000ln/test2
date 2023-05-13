using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionFromCrossword : MonoBehaviour
{

    public void EXIT()
    {
        for (int i = 0; i < 12; ++i)
            AllCrossword.guessed[i] = false;
        DataClass.off_cloud_krossword = true;
        SceneManager.LoadScene("14Frame");
    }


}
