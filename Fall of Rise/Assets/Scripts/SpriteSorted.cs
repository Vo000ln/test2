using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorted : MonoBehaviour
{
    public float offset = 0;
    private int sortingOrderBase = 0;
    private Renderer renderer;
    //изменение коллайдеров главного героя если он подошел к нпс, чтобы не наступать на них
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.tag == "PlayerMen")
    //     {
            

    //     }
    //     if (other.tag == "PlayerWoMen")
    //     {
            

    //     }
    // }

    // private void OnTriggerExit2D(Collider2D other)
    // {
        
    // }
    private void Awake(){
        renderer = GetComponent<Renderer>();
    }
    
    private void LateUpdate(){
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);
    }
}
