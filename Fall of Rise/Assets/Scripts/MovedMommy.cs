using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedMommy : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public bool fl = false;
    void Start(){
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        if(fl){
            Vector3 tmp = new Vector3(-1.1f,3.2f,-0.2f) - transform.position;
            if(tmp.y < 0.05f){
                transform.position = Vector3.Lerp(transform.position, new Vector3(-1.1f,3.2f,-0.2f), speed);
            }
            else if(tmp.y < 0.6f)
                transform.position = Vector3.Lerp(transform.position, new Vector3(-1.1f,3.2f,-0.2f), speed*Time.deltaTime*1.5f);
            else if(tmp.y < 0.3f)
                transform.position = Vector3.Lerp(transform.position, new Vector3(-1.1f,3.2f,-0.2f), speed*Time.deltaTime*3f);    
            else if(tmp.y < 0.15f)
                transform.position = Vector3.Lerp(transform.position, new Vector3(-1.1f,3.2f,-0.2f), speed*Time.deltaTime*6f);    
            else{
                transform.position = Vector3.Lerp(transform.position, new Vector3(-1.1f,3.2f,-0.2f), speed*Time.deltaTime);
            }
        }
    }
    public void start(){
        fl = true;
        DataClass.choose_conversation_mommy = 3; //активируется диалог после выбора, чтобы мама сама посмотрела списки
    }
}