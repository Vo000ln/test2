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
    public GameObject canvas_igor;
    public GameObject canvas_end;
    public GameObject o2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerMen" || other.tag == "PlayerWoman")
        {
            zone = true;
            if (DataClass.off_cloud_igor)
                canvas_igor.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        zone = false;
        if (DataClass.off_cloud_igor)
            canvas_igor.SetActive(false);
    }

    private void Update()
    {
        if (DataClass.off_cloud_hfr)
        {
            cloud.SetActive(false);
            after_meeting.SetActive(false);
        }
        if (DataClass.endDialogue == 1)
        {
            StartCoroutine(Coroutine());
            DataClass.endDialogue = 0;
        }
        if (zone && Input.GetKeyDown(KeyCode.E))
        {
            canvas_igor.SetActive(false);
            //1 диалог
            if (DataClass.choose_conversation_igor == 1)
            {
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_igor = 2;
            }
        }
    }

    public void off_cloud()
    {
        DataClass.off_cloud_igor = false;
    }

    IEnumerator Coroutine()
    {
        canvas_end.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        o2.GetComponent<SpriteRenderer>().enabled = false;
        DataClass.on_bed = true;
    }
}
