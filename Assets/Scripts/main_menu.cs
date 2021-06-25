using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public static int level = 0;
    public void PlayGame_1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        level = 1;
    }

    public void PlayGame_2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        level = 2;
    }

    public void PlayGame_3(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        level = 3;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
