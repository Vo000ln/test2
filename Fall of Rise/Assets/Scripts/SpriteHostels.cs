using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHostels : MonoBehaviour
{
    private Transform pos;

    void Start()
    {
        pos = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, -0.2f);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, 0f);

        }
    }
}
