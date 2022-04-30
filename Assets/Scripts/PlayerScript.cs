
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public float JumpForce;
    public float SlideForce;
    public float Speed;
    

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text ScoreTxt;
    public Animator PlayerAnimator;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
       
    }


    // Update is called once per frame
    void Update()
    {
      



        // Jumping 
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            
            }

            PlayerAnimator.SetBool("IsJumping", true);

        }
        else
        {
            PlayerAnimator.SetBool("IsJumping", false);

        }

        //Running 
        if (Input.GetKeyDown(KeyCode.DownArrow) && isGrounded == true)
        {

            PlayerAnimator.SetBool("IsSliding", true);
        
        } else
        {
            PlayerAnimator.SetBool("IsSliding", false);
        }


        //Walking


        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            
        
                isGrounded = true;
            
        }


        if (collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }
}