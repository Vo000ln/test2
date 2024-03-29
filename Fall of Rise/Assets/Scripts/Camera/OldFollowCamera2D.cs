using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldFollowCamera2D : MonoBehaviour
{

    public Transform target;
    public float smoothing;

    public Vector2 maxPos;
    public Vector2 minPos;

    private void FixedUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPos.x = Mathf.Clamp(targetPos.x, minPos.x, maxPos.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPos.y, maxPos.y);

            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (DataClass.gender == "M")
        {
            target = GameObject.FindGameObjectWithTag("PlayerMen").transform;
        }
        if (DataClass.gender == "W")
        {
            //Debug.Log("eeem");
            target = GameObject.FindGameObjectWithTag("PlayerWoman").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}