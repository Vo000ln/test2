using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CuratorMoveFromDoor : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public bool fl = false;
    public bool next = false;
    public bool end = false;
    public float max = 0.0f;

    public GameObject tutor;
    public GameObject anim_open_door;

    void Start(){
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        //Debug.Log(DataClass.endDialogue);
        if(!end){
            if (next){
                Vector3 tmp = new Vector3(8.5f, -3f, -2f) - transform.position;
                float distance = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                if(max == 0.0f)
                    max = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                transform.position = Vector3.Lerp(transform.position, new Vector3(8.5f, -3f, -2f), speed * Time.deltaTime * ((1.2f + (float)System.Math.Pow((max - distance), 1f))/(4)));
                if(System.Math.Abs(transform.position.x - 8.5f) < 0.05f && System.Math.Abs(transform.position.y + 3f) < 0.05f && System.Math.Abs(transform.position.z + 2f) < 0.05f)
                    end = true;
            }
            else{
                if (fl && (DataClass.endDialogue == 2))
                {
                    tutor.SetActive(true);
                    tutor.GetComponent<Animator>().SetBool("choose", true);
                    //StartCoroutine(Coroutine());
                    Vector3 tmp = new Vector3(16f, -4f, -2f) - transform.position;
                    float distance = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                    if(max == 0.0f)
                        max = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
                    transform.position = Vector3.Lerp(transform.position, new Vector3(16f, -4f, -2f), speed * Time.deltaTime * ((2.5f + (float)System.Math.Pow((max - distance), 3f))/(4)));
                    if(System.Math.Abs(transform.position.x - 16f) < 0.05f && System.Math.Abs(transform.position.y + 4f) < 0.05f && System.Math.Abs(transform.position.z + 2f) < 0.05f){
                        next = true;
                        max = 0.0f;
                    }
                }
            }
        }
        
    }

    public void start(){
        //УБРАТЬ ENDDIALOGUE
        //tutor.SetActive(true);
        //tutor.GetComponent<Animator>().SetBool("choose", true);

        //tutor.GetComponent<Animator>().enabled = false;
        //DataClass.endDialogue = 2;
        fl = true;
        
        //DataClass.choose_conversation_mommy = 3; //������������ ������ ����� ������, ����� ���� ���� ���������� ������
        //GetComponent<Animator>().enabled = true;
        //StartCoroutine(Coroutine());

    }
 
    IEnumerator Coroutine()
    {
        //tutor.SetActive(true);
        //tutor.GetComponent<Animator>().SetBool("choose", true);
        yield return new WaitForSecondsRealtime(3);
        //DataClass.endDialogue = 0;
        //Debug.Log(DataClass.endDialogue);
        //GetComponent<Animator>().enabled = false;
    }
}