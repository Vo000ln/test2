using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSleep : MonoBehaviour
{
    public bool zone = false;
    public bool once = true;
    public GameObject canvas_fade;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
    }

    void Update()
    {
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.on_bed && once)
        {
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {
        once = false;
        canvas_fade.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene("Frame_ekzamen");
    }
}
