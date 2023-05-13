using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CuratorMoveToDoor : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public bool fl = false;
    public bool next = false;
    void Start(){
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        //Debug.Log(DataClass.endDialogue);
        //Debug.Log(DataClass.choose_conversation_O1);
        //Debug.Log(DataClass.choose_conversation_O2);
        //Debug.Log(DataClass.choose_conversation_O3);
        if (fl && DataClass.endDialogue == 1 && (DataClass.choose_conversation_O1 == 1 || DataClass.choose_conversation_O2 == 1 || DataClass.choose_conversation_O3 == 1))
        {
            Vector3 tmp = new Vector3(16f, -2.6f, -2f) - transform.position;
            if(!next){
                if(tmp.y < 0.05f){
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2.6f, -2f), speed*Time.deltaTime*6f);
                }
                if(tmp.y < 0.01f){
                    next = true;
                }
                else if(tmp.y < 0.6f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2.6f, -2f), speed*Time.deltaTime*2f);
                else if(tmp.y < 0.3f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2.6f, -2f), speed*Time.deltaTime*3f);    
                else if(tmp.y < 0.15f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2.6f, -2f), speed*Time.deltaTime*4f);    
                else{
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2.6f, -2f), speed*Time.deltaTime);
                }
            }
            if(next){
                transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2f, -2f), speed*Time.deltaTime*3f);
            }
        }
        if(next){
            transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -2f, -2f), speed*Time.deltaTime);
        }
    }
    public void start(){
        DataClass.endDialogue = 0; //после того, как нажмется "закончить" DataClass.endDialogue станет равным 1
        fl = true;
        //DataClass.choose_conversation_mommy = 3; //������������ ������ ����� ������, ����� ���� ���� ���������� ������
        //GetComponent<Animator>().enabled = true;
        //StartCoroutine(Coroutine());

    }
 
    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(3);
        //DataClass.endDialogue = 0;
        //Debug.Log(DataClass.endDialogue);
        //GetComponent<Animator>().enabled = false;
    }
}