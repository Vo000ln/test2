using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NamePlayer : MonoBehaviour
{
    private Text mytxt;
    // Start is called before the first frame update
    void Start()
    {
        mytxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DataClass.name = mytxt.text.ToString();
    }
}
