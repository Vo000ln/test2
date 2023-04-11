using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MommyCharacter : MonoBehaviour
{
    //public NPCConversation myConversation;
    //public NPCConversation myConversation2;
    //public NPCConversation myConversation3;

    //private void OnMouseOver()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        //1 ������
    //        if (DataClass.choose_conversation_mommy == 1)
    //        {
    //            ConversationManager.Instance.StartConversation(myConversation);
    //            DataClass.choose_conversation_mommy = 0;
    //        }
    //        //���������� ������
    //        else if (DataClass.choose_conversation_mommy == 2)
    //        {
    //            ConversationManager.Instance.StartConversation(myConversation2);
    //            DataClass.choose_conversation_mommy = 0;
    //        }
    //        //����� ���� ������� � ��
    //        else if (DataClass.choose_conversation_mommy == 3)
    //        {
    //            ConversationManager.Instance.StartConversation(myConversation3);
    //            DataClass.choose_conversation_mommy = 0;
    //        }
    //    }
    //}

    public bool zone = false; //����, ����� �����, ����� �������� ������� � �������
    public NPCConversation myConversation;  //�������
    public NPCConversation myConversation2;
    public NPCConversation myConversation3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
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
        if (zone && Input.GetKeyDown(KeyCode.E))
        {
            //1 ������
            if (DataClass.choose_conversation_mommy == 1)
            {
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_mommy = 0;
            }
            //���������� ������
            else if (DataClass.choose_conversation_mommy == 2)
            {
                ConversationManager.Instance.StartConversation(myConversation2);
                DataClass.choose_conversation_mommy = 0;
            }
            //����� ���� ������� � ��
            else if (DataClass.choose_conversation_mommy == 3)
            {
                ConversationManager.Instance.StartConversation(myConversation3);
                DataClass.choose_conversation_mommy = 0;
            }
        }
    }
}
