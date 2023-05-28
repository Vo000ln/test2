using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEkz : MonoBehaviour
{
    public Transform posM, posW;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen")
        {
            posM.position = new Vector3(posM.position.x, posM.position.y, -1f);

        }else if(other.tag == "PlayerWoman")
        {
            posW.position = new Vector3(posW.position.x, posW.position.y, -1f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PlayerMen")
        {
            posM.position = new Vector3(posM.position.x, posM.position.y, -0.515f);

        }else if(other.tag == "PlayerWoman")
        {
            posW.position = new Vector3(posW.position.x, posW.position.y, -0.515f);
        }
    }
}
