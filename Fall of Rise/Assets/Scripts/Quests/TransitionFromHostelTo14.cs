using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionFromHostelTo14 : MonoBehaviour
{
    public bool zone = false;
    public GameObject canvas_fadeout;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
            //Debug.Log("OBJ");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
    }

    void Update()
    {
        if (zone)
        {
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {
        canvas_fadeout.SetActive(true);
        yield return new WaitForSecondsRealtime(1.9f);
        if (DataClass.gender == "M")
            Application.LoadLevel("14Frame");
        else
            Application.LoadLevel("Woman14Frame");
    }
}
