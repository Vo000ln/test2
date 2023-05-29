using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActiveFinal : MonoBehaviour
{
    public GameObject canvas_GoodEndMen1;
    public GameObject canvas_GoodEndWoman2;
    public GameObject canvas_BadEndMen3;
    public GameObject canvas_BadEndWoman4;

    void Start()
    {
        if (DataClass.final_anim == 1)
            canvas_GoodEndMen1.SetActive(true);
        if (DataClass.final_anim == 2)
            canvas_GoodEndWoman2.SetActive(true);
        if (DataClass.final_anim == 3)
            canvas_BadEndMen3.SetActive(true);
        if (DataClass.final_anim == 4)
            canvas_BadEndWoman4.SetActive(true);
    }
}
