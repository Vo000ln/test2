using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CuratorMoveToDoor : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public bool fl = false;
    public bool next = false;
    public bool end = false;
    public float max = 0.0f;
    public bool end_anim = true;

    public GameObject anim_open_door;
    public GameObject tutor;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        //Debug.Log(DataClass.endDialogue);
        //Debug.Log(DataClass.choose_conversation_O1);
        //Debug.Log(DataClass.choose_conversation_O2);
        //Debug.Log(DataClass.choose_conversation_O3);
        if(!end)
        {
            if (next)
            {
                //GetComponent<Animator>().enabled = true;
                Vector3 tmp = new Vector3(16f, -2f, -2f) - transform.position;
                float distance = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                if(max == 0.0f)
                    max = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2f, -2f), speed * Time.deltaTime * ((1.2f + (float)System.Math.Pow((max - distance), 1.4f))/(4)));
                if(System.Math.Abs(transform.position.x - 16f) < 0.05f && System.Math.Abs(transform.position.y + 2f) < 0.05f && System.Math.Abs(transform.position.z + 2f) < 0.05f)
                {
                    end = true;
                    //anim_open_door.GetComponent<Animator>().enabled = false;
                }
            }
            else
            {
                if (fl && DataClass.endDialogue == 1 && (DataClass.choose_conversation_O1 == 1 || DataClass.choose_conversation_O2 == 1 || DataClass.choose_conversation_O3 == 1))
                {
                    GetComponent<Animator>().enabled = true;
                    //выключить корутин (выключить скрипт после его выполнения)
                    StartCoroutine(Coroutine());
                    Vector3 tmp = new Vector3(16f, -2.6f, -2f) - transform.position;
                    float distance = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                    if(max == 0.0f)
                        max = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2.6f, -2f), speed * Time.deltaTime * ((1.2f + (float)System.Math.Pow((max - distance), 1f))/(4)));
                    if(System.Math.Abs(transform.position.x - 16f) < 0.05f && System.Math.Abs(transform.position.y + 2.6f) < 0.05f && System.Math.Abs(transform.position.z + 2f) < 0.05f){
                        next = true;
                    }
                }
            }
        }
        
    }

    public void start()
    {
        //ПОКА ЧТО 1 НА ENDDIALOGUE, А ТАК 0
        DataClass.endDialogue = 0; //после того, как нажмется "закончить" DataClass.endDialogue станет равным 1
        fl = true;
        //anim_open_door.GetComponent<Animator>().enabled = true;
        //GetComponent<Animator>().enabled = true;
        //DataClass.choose_conversation_mommy = 3; //������������ ������ ����� ������, ����� ���� ���� ���������� ������
        //GetComponent<Animator>().enabled = true;
        //StartCoroutine(Coroutine());
    }
 
    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(3);
        if (end_anim)
            anim_open_door.GetComponent<Animator>().enabled = true;
        yield return new WaitForSecondsRealtime(1.5f);
        //tutor.SetActive(false);
        tutor.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSecondsRealtime(0.5f);
        anim_open_door.GetComponent<Animator>().enabled = false;
        end_anim = false;

        //DataClass.endDialogue = 2;
        //anim_open_door = GetComponent<Animator>();
        //anim_open_door.GetComponent<Animator>().enabled = true;
        //DataClass.endDialogue = 0;
        //Debug.Log(DataClass.endDialogue);
        //GetComponent<Animator>().enabled = false;
    }
}