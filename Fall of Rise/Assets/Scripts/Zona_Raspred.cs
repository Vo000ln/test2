using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Zona_Raspred : MonoBehaviour
{
    //public GameObject canvas_1, canvas_2, canvas_3, canvas_4, canvas_5, canvas_6, canvas_7, canvas_8, canvas_9, canvas_10, canvas_11, canvas_12;
    public bool zone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
            //Debug.Log(this.gameObject.name.GetType());
            DataClass.zone_num = Int32.Parse(this.gameObject.name);
            //Debug.Log(DataClass.zone_num.GetType());

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
        DataClass.zone_num = 0;
    }

}
