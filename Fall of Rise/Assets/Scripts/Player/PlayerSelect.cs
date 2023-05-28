using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    private GameObject[] characters;
    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("SelectPlayer");

        characters = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; ++i)
        {
            characters[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject go in characters)
        {
            go.SetActive(false);
        }
        if (characters[index])
        {
            //����������� ������ ���� ���������, 1 - �, 0 - �
            if (index == 1)
                DataClass.gender = "W";
            else
                DataClass.gender = "M";

            characters[index].SetActive(true);
        }
    }

    public void SelectLeft()
    {
        characters[index].SetActive(false);
        --index;
        if(index < 0)
        {
            index = characters.Length - 1;
        }

        //����������� ������ ���� ���������, 0 - �, 1 - �
        if (index == 1)
            DataClass.gender = "W";
        else
            DataClass.gender = "M";

        //Debug.Log(index);

        characters[index].SetActive(true);
    }

    public void SelectRight()
    {
        characters[index].SetActive(false);
        ++index;
        if (index == characters.Length)
        {
            index = 0;
        }

        //����������� ������ ���� ���������, 0 - �, 1 - �
        if (index == 1)
            DataClass.gender = "W";
        else
            DataClass.gender = "M";

        //Debug.Log(index);

        characters[index].SetActive(true);
    }

    public void StartScene()
    {
        if(DataClass.name.Length > 2)
        {
            PlayerPrefs.SetInt("SelectPlayer", index);
            DataClass.trans_on = true;
        }
    }
}
