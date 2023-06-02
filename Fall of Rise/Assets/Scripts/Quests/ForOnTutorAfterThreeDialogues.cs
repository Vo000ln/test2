using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForOnTutorAfterThreeDialogues : MonoBehaviour
{
    public GameObject tutor;
    public GameObject obj;

    void Update()
    {
        if (DataClass.endDialogue == 4)
        {
            tutor.SetActive(true);
            obj.SetActive(false);
        }
    }
}
