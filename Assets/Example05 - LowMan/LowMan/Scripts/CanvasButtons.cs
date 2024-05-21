using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public void NextScene_1()
    {
        SceneManager.LoadScene(1);
    }
    public void NextScene_2()
    {
        SceneManager.LoadScene(2);
    }
    public void NextScene_3()
    {
        SceneManager.LoadScene(3);
    }
    public void NextScene_0()
    {
        SceneManager.LoadScene(0);
    }
    public void ToMenu()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(0);
        }
    }
}