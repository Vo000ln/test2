using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogManager dm;

    public void OnTriggerEnter2D(Collider2D other)  //near zone npc - open
    {
        startAnim.SetBool("startOpen", true);
    }

    public void OnTriggerExit2D(Collider2D other)  //and close
    {
        startAnim.SetBool("startOpen", false);
        dm.EndDialog();
    }
}
