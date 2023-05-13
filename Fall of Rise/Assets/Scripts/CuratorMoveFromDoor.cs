using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CuratorMoveFromDoor : MonoBehaviour
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
        if (fl && (DataClass.endDialogue == 2))
        {
            
            if(!next){
                Vector3 tmp = new Vector3(16f, -4f, -2f) - transform.position;
                if(tmp.y < 0.05f){
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -4f, -2f), speed*Time.deltaTime*6f);
                    if(tmp.y < 0.01f)
                        next = true;
                }
                else if(tmp.y < 0.6f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -4f, -2f), speed*Time.deltaTime*2f);
                else if(tmp.y < 0.3f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -4f, -2f), speed*Time.deltaTime*3f);    
                else if(tmp.y < 0.15f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -4f, -2f), speed*Time.deltaTime*4f);    
            }
            if(next){
                Vector3 tmp = new Vector3(7.5f, -3f, -2f) - transform.position;
                if(tmp.x < 0.25f){
                    transform.position = Vector3.Lerp(transform.position, new Vector3(7.5f, -3f, -2f), speed*Time.deltaTime*6f);
                }
                else if(tmp.x < 2f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(7.5f, -3f, -2f), speed*Time.deltaTime*2f);
                else if(tmp.x < 1f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(7.5f, -3f, -2f), speed*Time.deltaTime*3f);    
                else if(tmp.x < 0.5f)
                    transform.position = Vector3.Lerp(transform.position, new Vector3(7.5f, -3f, -2f), speed*Time.deltaTime*4f);
            }
            
        }
        
    }
    public void start(){
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