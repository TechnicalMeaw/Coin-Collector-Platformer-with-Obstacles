using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    public Animator animator;

    float HorizontalMove = 0f;

    public float runSpeed = 3;
    public float jumpSpeed = 7;
    public ParticleSystem JumpDust;
    public ParticleSystem Cherry;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CoinCounterScript.coinAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        HorizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        transform.Translate(HorizontalMove * Time.deltaTime, 0f, 0f);
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        Vector3 characterScale = transform.localScale;
        if (HorizontalMove < 0){
            characterScale.x = -10;
            
        }

        if (HorizontalMove > 0){
            characterScale.x = 10;
        }
        transform.localScale = characterScale;


        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(KeyCode.UpArrow) && onGround){
            animator.SetBool("Jump", true);
            JumpDust.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        
        if(!onGround){
            animator.SetBool("Jump", true);
        }else{
            animator.SetBool("Jump", false);
        }

    }

    private void OnTriggerEnter2D(Collider2D other){

        if (other.gameObject.CompareTag("Coin")){
            CoinCounterScript.coinAmount += 1;
            FindObjectOfType<AudioManager>().Play("Coin_collect");
            Destroy(other.gameObject);
        }

        

        if (other.gameObject.CompareTag("Tree")){
            Cherry.Play();
        }
    }
}
