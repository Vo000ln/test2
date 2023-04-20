using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewNewFollow : MonoBehaviour
{

    public GameObject player; // тут объект игрока
    private Vector3 offset;  

    void Start () 
    {        
        offset = transform.position - player.transform.position;
    }

    void Update () 
    {        
        transform.position = player.transform.position + offset;
    }
}
