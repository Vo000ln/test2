using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToQuest : MonoBehaviour
{
    public GameObject crossword;
    public GameObject questions;
    public void to_quest()
    {
        questions.SetActive(true);
        crossword.SetActive(false);
    }
    public void to_crossword()
    {
        questions.SetActive(false);
        crossword.SetActive(true);
    }
}
