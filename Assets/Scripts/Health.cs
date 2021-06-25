using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 2;

    public GameObject heart1;
    public GameObject heart2;
    // Start is called before the first frame update
    void Update()
    {
        if (health == 0){
            Destroy(heart1.gameObject);
            Died();
        }

        if (health == 1){
            Destroy(heart2.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.CompareTag("Enemy")){
            health -=1;
            FindObjectOfType<AudioManager>().Play("playerDeath");
        }

        if (other.gameObject.CompareTag("Fire")){
            health = 0;
            FindObjectOfType<AudioManager>().Play("playerDeath");
        }
    }


    public void Died(){
        SceneManager.LoadScene("Death_screen");
    }
}
