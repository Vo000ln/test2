using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MommyCharacter : MonoBehaviour
{
    public bool zone = false; //зона, чтобы знать, когда персонаж подошел к объекту
    public NPCConversation myConversation;  //диалоги
    public NPCConversation myConversation2;
    public NPCConversation myConversation3;

    public GameObject cloud;
    public GameObject canvas_fadein;

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
        if (DataClass.off_cloud1)
        {
            cloud.SetActive(false);
            canvas_fadein.SetActive(false);
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.move == 0)
        {
            cloud.SetActive(false);
            //1 диалог
            if (DataClass.choose_conversation_mommy == 1)
            {
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_mommy = 0;
            }
            //посмотреть самому
            else if (DataClass.choose_conversation_mommy == 2)
            {
                ConversationManager.Instance.StartConversation(myConversation2);
                DataClass.choose_conversation_mommy = 0;
            }
            //чтобы мама подошла к пк
            else if (DataClass.choose_conversation_mommy == 3)
            {
                ConversationManager.Instance.StartConversation(myConversation3);
                DataClass.choose_conversation_mommy = 0;
            }
        }
    }
}
