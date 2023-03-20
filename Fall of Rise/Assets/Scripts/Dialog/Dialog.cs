using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog
{
    public string name;
    [TextArea(1, 10)] //max and min dialog
    public string[] sentences;  //massive dialog string
}
