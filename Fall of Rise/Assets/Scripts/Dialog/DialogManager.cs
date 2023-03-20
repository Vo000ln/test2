using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public Text nameText;

    public Animator boxAnim;
    public Animator startAnim;

    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        GameObject.Find("Player_choose/Characters/Men").GetComponent<PlayerController>().enabled = false; //FOR STOP MEN (WOMEN YET...)

        boxAnim.SetBool("boxOpen", true); //want to try dialog window
        startAnim.SetBool("startOpen", false); //close start button

        nameText.text = dialog.name;    //name npc
        sentences.Clear(); //clear text

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence); //queue in buf
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)  //buf = 0
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue(); //delete string in buf
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    //interface for alpha
    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach(char letter in sentence.ToCharArray()) //for every char in sentence
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    public void EndDialog() //close dialog
    {
        GameObject.Find("/Player_choose/Characters/Men").GetComponent<PlayerController>().enabled = true;
        boxAnim.SetBool("boxOpen", false);
    }

}
