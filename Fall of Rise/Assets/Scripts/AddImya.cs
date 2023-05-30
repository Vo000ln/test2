using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddImya : MonoBehaviour
{
    public TMP_Text imya;
    // Start is called before the first frame update
    //sllls
    public void setext()
    {
        imya.text = DataClass.name;        
    }

}
