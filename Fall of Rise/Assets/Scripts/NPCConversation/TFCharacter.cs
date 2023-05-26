using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;

public class TFCharacter : MonoBehaviour
{
    public bool zone = false; //зона, чтобы знать, когда персонаж подошел к объекту
    public NPCConversation myConversation;  //диалоги

    public GameObject cloud_AfterCab;
    public GameObject canvas_startpuzzle;

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
        if (DataClass.endDialogue == 2)
        {
            DataClass.endDialogue = 0;
            StartCoroutine(Coroutine());
        }
        if (zone && Input.GetKeyDown(KeyCode.E) && DataClass.move == 0)
        {
            //1 диалог
            if (DataClass.choose_conversation_TF == 0 && DataClass.choose_conversation_O2EKZ == 1)
            {
                cloud_AfterCab.SetActive(false);
                ConversationManager.Instance.StartConversation(myConversation);
                DataClass.choose_conversation_TF = 1;
                DataClass.choose_conversation_O2EKZ = 2;
            }
        }
    }

    IEnumerator Coroutine()
    {
        canvas_startpuzzle.SetActive(true);
        yield return new WaitForSecondsRealtime(2.9f);
        SceneManager.LoadScene("Puzzle");
    }
}
