using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winnning_menu : MonoBehaviour
{
    public GameObject next;

    void Update(){
        if(main_menu.level == 3){
            Destroy(next);
        }
    }
    // Start is called before the first frame update
    public void BackToMainMenu(){
        SceneManager.LoadScene(0);
    }

    public void Retry(){
        SceneManager.LoadScene(main_menu.level);
    }

    public void Next(){
        SceneManager.LoadScene(main_menu.level +1);
        main_menu.level += 1;
    }

}
