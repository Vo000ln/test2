using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TFCharacter : MonoBehaviour
{
    public bool zone = false; //����, ����� �����, ����� �������� ������� � �������
    public NPCConversation myConversation;  //�������

    public GameObject cloud_AfterCab;

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
            if (DataClass.choose_conversation_TF == 0 && DataClass.choose_conversation_O2EKZ == 1)
            {
                cloud_AfterCab.SetActive(false);
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_TF = 1;
                DataClass.choose_conversation_O2EKZ = 2;
            }
        }
    }
}
