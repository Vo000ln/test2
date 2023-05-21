using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForDoor : MonoBehaviour
{
    // private Vector2 size;
    // private Vector2 offset;
    public Transform posM,posW;
    // void Start(){
    //     pos =  GetComponent<Transform>();
    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen")
        {
            posM.position = new Vector3(posM.position.x, posM.position.y, 1f);
            
        }
        if (other.tag == "PlayerWoman")
        {
            posW.position = new Vector3(posW.position.x, posW.position.y, 1f);
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PlayerMen")
        {
            posM.position = new Vector3(posM.position.x, posM.position.y, 0.4f);
            
        }
        if (other.tag == "PlayerWoman")
        {
            posW.position = new Vector3(posW.position.x, posW.position.y, 0.4f);
            
        }
    }
    //изменение коллайдеров главного героя если он подошел к нпс, чтобы не наступать на них
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
    //     {
    //         if (other.tag == "PlayerMen")
    //         {
    //             size = new Vector2(0.5625f, 0.2452773f);
    //             offset = new Vector2(0, -0.4685132f);  
    //             Vector2 S = GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<SpriteRenderer>().sprite.bounds.size;
    //             GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<BoxCollider2D>().size = S;
    //             GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
    //         }
    //         if (other.tag == "PlayerWoman")
    //         {
    //             size = new Vector2(0.5625f, 0.2262964f);
    //             offset = new Vector2(0, -0.5417128f);  
    //             Vector2 S = GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<SpriteRenderer>().sprite.bounds.size;
    //             GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<BoxCollider2D>().size = S;
    //             GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
    //         }
    //     }
    // }

    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.tag == "PlayerMen")
    //         {
    //             GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<BoxCollider2D>().size = size;
    //             GameObject.FindGameObjectWithTag("PlayerMen").GetComponent<BoxCollider2D>().offset = offset;
    //         }
    //         if (other.tag == "PlayerWoman")
    //         {
    //             GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<BoxCollider2D>().size = size;
    //             GameObject.FindGameObjectWithTag("PlayerWoman").GetComponent<BoxCollider2D>().offset = offset;
    //         }
    // }
}
