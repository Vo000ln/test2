using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TF2Character : MonoBehaviour
{
    public bool zone = false; //зона, чтобы знать, когда персонаж подошел к объекту
    public NPCConversation myConversation;  //диалоги

    public GameObject canvas_cloudbilet;
    public GameObject transition_to_crossword;

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
        if (DataClass.endDialogue == 1)
        {
            canvas_cloudbilet.SetActive(true);
            transition_to_crossword.SetActive(true);
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.move == 0)
        {
            //1 диалог
            if (DataClass.choose_conversation_TF2 == 0)
            {
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_TF2 = 1;
            }
        }
    }
}
