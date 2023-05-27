using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class O1Character : MonoBehaviour
{
    public bool zone = false; //����, ����� �����, ����� �������� ������� � �������
    public NPCConversation myConversation;  //�������

    public GameObject canvas_fadein;

    void Start()
    {
        StartCoroutine(Coroutine());
    }
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

    private void Update()
    {
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.move == 0)
        {
            //1 ������
            if (DataClass.choose_conversation_O1 == 1)
            {
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_O1 = 2;
                DataClass.choose_conversation_tutor = 2; //����� ��������� � �������������� � ��������� ������������ ����� ������
            }
        }
    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(1);
        canvas_fadein.SetActive(false);
    }
}
