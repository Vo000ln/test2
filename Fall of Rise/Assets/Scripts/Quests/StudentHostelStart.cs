using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentHostelStart : MonoBehaviour
{
    //public bool zone = false;
    public GameObject fadeOut;
    public GameObject telephone;

    //private void OnTriggerEnter2D(Collider2D other)
    //{

    //    if (other.tag == "Player")
    //    {
    //        zone = true;
    //        //Debug.Log("OBJ");
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    zone = false;
    //}

    void Start()
    {
        //telephone = GetComponent<AudioSource>();
        StartCoroutine(Coroutine()); //��� �������� � +- ����������� �������� �����
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(17); //������������ ��������
        fadeOut.SetActive(false); //��������� ��������
        GameObject.Find("Telephone").GetComponent<AudioSource>().enabled = true; //�������� ������ ��������
        //telephone.enabled = true;
        //DataClass.endDialogue = 0;
        //Application.LoadLevel("StudentHostel");
    }

    //void Update()
    //{
    //    if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.endDialogue == 1)
    //    {
    //        fadeIn.SetActive(true); //���������� ��������
    //        StartCoroutine(Coroutine()); //��� �������� � +- ����������� �������� �����
    //    }
    //}

    //IEnumerator Coroutine()
    //{
    //    yield return new WaitForSecondsRealtime(2);
    //    DataClass.endDialogue = 0;
    //    Application.LoadLevel("StudentHostel");
    //}
}
