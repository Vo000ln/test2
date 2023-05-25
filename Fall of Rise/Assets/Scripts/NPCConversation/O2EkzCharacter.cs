using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class O2EkzCharacter : MonoBehaviour
{
    public bool zone = false; //зона, чтобы знать, когда персонаж подошел к объекту
    public bool once_cloud = true;
    public NPCConversation myConversation;  //диалоги

    public GameObject cloud_OgoVasya;
    public GameObject cloud_BeforeCab;

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
        if (DataClass.endDialogue == 1 && once_cloud)
        {
            cloud_BeforeCab.SetActive(true);
            once_cloud = false;
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.move == 0)
        {
            //1 диалог
            if (DataClass.choose_conversation_O2EKZ == 0)
            {
                cloud_OgoVasya.SetActive(false);
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_O2EKZ = 1;
                //тут еще добавить что с ТФ может болтать; upd сделала это в TFCharacter
            }
        }
    }
}
