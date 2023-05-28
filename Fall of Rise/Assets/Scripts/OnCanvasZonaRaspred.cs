using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCanvasZonaRaspred : MonoBehaviour
{
    public GameObject canvas_1, canvas_2, canvas_3, canvas_4, canvas_5, canvas_6, canvas_7, canvas_8, canvas_9, canvas_10, canvas_11, canvas_12;
    
    void Update()
    {
        switch (DataClass.zone_num)
        {
            case 1:
                canvas_1.SetActive(true);
                break;
            case 2:
                canvas_2.SetActive(true);
                break;
            case 3:
                canvas_3.SetActive(true);
                break;
            case 4:
                canvas_4.SetActive(true);
                break;
            case 5:
                canvas_5.SetActive(true);
                break;
            case 6:
                canvas_6.SetActive(true);
                break;
            case 7:
                canvas_7.SetActive(true);
                break;
            case 8:
                canvas_8.SetActive(true);
                break;
            case 9:
                canvas_9.SetActive(true);
                break;
            case 10:
                canvas_10.SetActive(true);
                break;
            case 11:
                canvas_11.SetActive(true);
                break;
            case 12:
                canvas_12.SetActive(true);
                break;
            default:
                canvas_1.SetActive(false);
                canvas_2.SetActive(false);
                canvas_3.SetActive(false);
                canvas_4.SetActive(false);
                canvas_5.SetActive(false);
                canvas_6.SetActive(false);
                canvas_7.SetActive(false);
                canvas_8.SetActive(false);
                canvas_9.SetActive(false);
                canvas_10.SetActive(false);
                canvas_11.SetActive(false);
                canvas_12.SetActive(false);
                break;
        }

        //if (DataClass.zone_num   1)
        //    canvas_1.SetActive(true);
        //if (DataClass.zone_num   2)
        //    canvas_2.SetActive(true);
        //if (DataClass.zone_num   3)
        //    canvas_3.SetActive(true);
        //if (DataClass.zone_num   4)
        //    canvas_4.SetActive(true);
        //if (DataClass.zone_num   5)
        //    canvas_5.SetActive(true);
        //if (DataClass.zone_num   6)
        //    canvas_6.SetActive(true);
        //if (DataClass.zone_num   7)
        //    canvas_7.SetActive(true);
        //if (DataClass.zone_num   8)
        //    canvas_8.SetActive(true);
        //if (DataClass.zone_num   9)
        //    canvas_9.SetActive(true);
        //if (DataClass.zone_num   10)
        //    canvas_10.SetActive(true);
        //if (DataClass.zone_num   11)
        //    canvas_11.SetActive(true);
        //if (DataClass.zone_num   12)
        //    canvas_12.SetActive(true);
        //else
        //{
        //    canvas_1.SetActive(true);
        //    canvas_2.SetActive(true);
        //    canvas_3.SetActive(true);
        //    canvas_4.SetActive(true);
        //    canvas_5.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //    canvas_12.SetActive(true);
        //}
    }
}
