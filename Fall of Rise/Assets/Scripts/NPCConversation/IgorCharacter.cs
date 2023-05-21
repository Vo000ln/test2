using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class IgorCharacter : MonoBehaviour
{
    public bool zone = false; //зона, чтобы знать, когда персонаж подошел к объекту
    public NPCConversation myConversation;  //диалоги
    //public NPCConversation myConversation2;
    //public NPCConversation myConversation3;
    public GameObject cloud;
    public GameObject after_meeting;

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
        if (DataClass.off_cloud_hfr)
        {
            cloud.SetActive(false);
            after_meeting.SetActive(false);
        }
        if (zone && Input.GetKeyDown(KeyCode.E))
        {
            //1 диалог
            if (DataClass.choose_conversation_igor == 1)
            {
                ConversationManager.Instance.StartConversation(myConversation);
            }
        }
    }
}
