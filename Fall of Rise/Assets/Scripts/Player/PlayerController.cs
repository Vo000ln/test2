using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;
public class PlayerController : MonoBehaviour
{
    
    private Rigidbody2D myRB;
    [SerializeField] private float speed;
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (DataClass.move == 0)
        {
            speed = 5;
            myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;


            Anim.SetFloat("moveY", myRB.velocity.y);
            Anim.SetFloat("moveX", myRB.velocity.x);
            if (Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Vertical") == -1 || Input.GetAxisRaw("Vertical") == 1)
            {
                Anim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                Anim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }
        }
        else
        {
            speed = 0;
            myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;


            Anim.SetFloat("moveY", myRB.velocity.y);
            Anim.SetFloat("moveX", myRB.velocity.x);
            if (Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Vertical") == -1 || Input.GetAxisRaw("Vertical") == 1)
            {
                Anim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                Anim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }
        }

    }

}
