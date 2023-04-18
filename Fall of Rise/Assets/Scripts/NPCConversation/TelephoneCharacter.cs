using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TelephoneCharacter : MonoBehaviour
{
    public bool zone = false;
    public bool for_one = true;
    public NPCConversation myConversation;

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
        if (zone && Input.GetKeyDown(KeyCode.E) && for_one)
        {
            ConversationManager.Instance.StartConversation(myConversation);
            for_one = false;
        }
    }
}