using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
 
    // Update is called once per frame
    public void QuitGame()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }
}
