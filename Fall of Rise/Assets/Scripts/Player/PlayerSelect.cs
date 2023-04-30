using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            //запоминание выбора пола персонажа, 1 - ж, 0 - м
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

        //запоминание выбора пола персонажа, 0 - ж, 1 - м
        if (index == 1)
            DataClass.gender = "W";
        else
            DataClass.gender = "M";

        Debug.Log(index);

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

        //запоминание выбора пола персонажа, 0 - ж, 1 - м
        if (index == 1)
            DataClass.gender = "w";
        else
            DataClass.gender = "m";

        Debug.Log(index);

        characters[index].SetActive(true);
    }

    public void StartScene()
    {
        if(DataClass.name.Length > 0){
            PlayerPrefs.SetInt("SelectPlayer", index);
            SceneManager.LoadScene("HomePlayer");
        }
    }
}
