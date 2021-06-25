using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinColliderScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.CompareTag("Player")){
            Won();
        }
    }

    public void Won(){
        SceneManager.LoadScene("Winning_screen");
    }

}
