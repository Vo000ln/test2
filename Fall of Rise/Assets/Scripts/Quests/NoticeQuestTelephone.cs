using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoticeQuestTelephone : MonoBehaviour
{
    public GameObject notice;
    public GameObject end_dialogue;

    void Start()
    {
        
    }

    void Update()
    {
        //1   
        //  1 - ýōî ęîãäā ėû ņî ņöåíû StudentHostel ņðāįó íāũčíāåė, 3 - äëĸ ōîãî, ũōîáû ņ ņāėîãî íāũāëā čãðû
        if (DataClass.endDialogue == 3 || DataClass.endDialogue == 1)
        {
            notice.SetActive(true); // 
            DataClass.endDialogue = 0;
            GameObject.Find("EndDialogue").GetComponent<NoticeQuestTelephone>().enabled = false; //     
        }
    }


}
