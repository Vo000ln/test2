using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedMommy : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public bool fl = false;
    public float max = 0f; 

    void Start(){
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        if(fl)
        {
            Vector3 tmp = new Vector3(-1.1f, 3.2f, -0.2f) - transform.position;
            float distance = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
            if(max == 0.0f)
                max = (float)System.Math.Sqrt(tmp.x * tmp.x + tmp.y * tmp.y);
            transform.position = Vector3.Lerp(transform.position, new Vector3(-1.1f,3.2f,transform.position.z), speed * Time.deltaTime * ((1.2f + (float)System.Math.Pow((max - distance), 2.7f))/(4)));
        }
    }
    public void start(){
        fl = true;
        DataClass.choose_conversation_mommy = 3; //������������ ������ ����� ������, ����� ���� ���� ���������� ������
        GetComponent<Animator>().enabled = true;
        StartCoroutine(Coroutine());

    }

    IEnumerator Coroutine()
    {
        yield return new WaitForSecondsRealtime(3);
        GetComponent<Animator>().enabled = false;
    }
}