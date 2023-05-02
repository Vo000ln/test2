using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AppearanceCloud : MonoBehaviour
{
    public bool zone = false;
    public GameObject notice;
    public bool for_one = true;
    public GameObject fadeIn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "PlayerMen" || other.tag == "PlayerWoman") && for_one)
        {
            zone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
        notice.SetActive(false);
    }

    private void Update()
    {
        if (zone)
        {
            notice.SetActive(true);
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && for_one)
        {
            zone = false; //��������� ������ � ����
            notice.SetActive(false); //������ ������ ����������
            for_one = false; //����� � ���������� �������� �� ��� ������ �� ������

            //(����� ��� ������� ��������)
            fadeIn.SetActive(true);
            StartCoroutine(Coroutine());
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(7);
        fadeIn.SetActive(false);
        //��� ������ ���� ������� �� ����� �����
        SceneManager.LoadScene("Crossword");
    }
}
