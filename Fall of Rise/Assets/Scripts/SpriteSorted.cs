using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorted : MonoBehaviour
{
    //изменение коллайдеров главного героя если он подошел к нпс, чтобы не наступать на них
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            if (other.tag == "PlayerMen")
            {
                Vector2 S = GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<SpriteRenderer>().sprite.bounds.size;
                GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<BoxCollider2D>().size = S;
                GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
            }
            if (other.tag == "PlayerWoman")
            {
                Vector2 S = GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<SpriteRenderer>().sprite.bounds.size;
                GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<BoxCollider2D>().size = S;
                GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

    }
}
