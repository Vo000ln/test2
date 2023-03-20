using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    public Text canvasText1;
    public Text canvasText2;
    public Text canvasText3;

    //void Start()
    //{
    //    Invoke("DisableText", 0f);//invoke after 2 seconds
    //    Invoke("AbleText", 3f);//invoke after 2 seconds

    //}
    //void DisableText()
    //{
    //    canvasText1.enabled = false;
    //    canvasText2.enabled = false;
    //    canvasText3.enabled = false;
    //}
    //void AbleText()
    //{
    //    canvasText1.enabled = true;
    //    canvasText2.enabled = true;
    //    canvasText3.enabled = true;
    //}

    bool create = false;

    void Update()
    {
        if (!create)
        {
            Invoke();
            create = true;
        }
    }

    void Invoke()
    {
        Invoke("DisableText", 0f);//invoke after 2 seconds
        Invoke("AbleText", 3f);//invoke after 2 seconds
    }

    void DisableText()
    {
        canvasText1.enabled = false;
        canvasText2.enabled = false;
        canvasText3.enabled = false;
    }
    void AbleText()
    {
        canvasText1.enabled = true;
        canvasText2.enabled = true;
        canvasText3.enabled = true;
    }
}
