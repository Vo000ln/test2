using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TelephoneCharacter : MonoBehaviour
{
    public bool zone = false;
    public bool for_one = true;
    public GameObject cloud;
    public NPCConversation myConversation;

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
        if (zone && Input.GetKeyDown(KeyCode.E) && for_one && DataClass.move == 0)
        {
            cloud.SetActive(false);
            ConversationManager.Instance.StartConversation(myConversation);
            DataClass.choose_conversation_tutor = 1; //после активации телефона сделали так, чтобы смог произойти дальнейший диалог с куратором в 14к
            for_one = false;
        }
    }
}