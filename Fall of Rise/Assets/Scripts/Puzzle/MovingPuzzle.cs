using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPuzzle : MonoBehaviour
{
    bool move;
    Vector2 mousePos;
    float startPosX;
    float startPosY;
    public GameObject form;
    bool finish;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = true;
            mousePos = Input.mousePosition;
            //mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp()
    {
        move = false;
        //mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 50f &&
           Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 50f && finish != true)
        {
            this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder--;
            this.gameObject.GetComponent<SpriteRenderer>().sortingOrder--;
            finish = true;
            ++DataClass.count_elements;
        }
    }

    void Update()
    {
        if (move == true && finish == false)
        {
            mousePos = Input.mousePosition;
            //mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }

    //bool move;
    //Vector3 mousePos;

    //void OnMouseDown()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        move = true;
    //        mousePos = Input.mousePosition;
    //    }
    //}

    //void Update()
    //{
    //    if (move == true)
    //    {
    //        mousePos = Input.mousePosition;
    //        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

    //        //this.gameObject.GetComponent<SpriteRenderer>().flipX. = isLeftSided;
    //        this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
    //    }
    //}
}
