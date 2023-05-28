using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToStudentHostel : MonoBehaviour
{
    public bool zone = false;
    public GameObject fadeIn;

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
        if (zone  && DataClass.endDialogue == 2)
        {
            fadeIn.SetActive(true); //���������� ��������
            StartCoroutine(Coroutine()); //��� �������� � +- ����������� �������� �����
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(2);
        DataClass.endDialogue = 0;
        if (DataClass.gender == "M")
            Application.LoadLevel("StudentHostel");
        else
            Application.LoadLevel("WomanStudentHostel");
    }

}
