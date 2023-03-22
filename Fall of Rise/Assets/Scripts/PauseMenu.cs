using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
     
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            DataClass.scene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Menu");
        } 
    } 
}
