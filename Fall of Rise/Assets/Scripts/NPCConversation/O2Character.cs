using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class O2Character : MonoBehaviour
{
    public bool zone = false; //зона, чтобы знать, когда персонаж подошел к объекту
    public NPCConversation myConversation;  //диалоги
    //public NPCConversation myConversation2;
    //public NPCConversation myConversation3;

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
        if (zone && Input.GetKeyDown(KeyCode.E))
        {
            //1 диалог
            if (DataClass.choose_conversation_O2 == 1) //0, для теста; 1, после разговора с кураторшей
            {
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_O2 = 2; //поменять на 2
                DataClass.choose_conversation_tutor = 2; //после разговора с одногруппником у кураторши активируется новый диалог
            }
        }
    }
}
