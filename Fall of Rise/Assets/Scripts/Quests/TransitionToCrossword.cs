using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToCrossword : MonoBehaviour
{
    public bool zone = false; //����, ����� �����, ����� �������� ������� � �������
    bool once = true;
    public GameObject canvas_fadeout;

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
        if (zone && Input.GetKeyDown(KeyCode.E) && once)
        {
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {
        once = false;
        canvas_fadeout.SetActive(true);
        yield return new WaitForSecondsRealtime(15.9f);
        //��� ���� ����������, ��� ���� ������
        SceneManager.LoadScene("Crossword");
    }
}
