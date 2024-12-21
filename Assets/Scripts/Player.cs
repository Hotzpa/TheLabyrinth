using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    
    public int num;

    public Rigidbody rb;

    
    public  float Speed = 1f;
    public  float Gravity = 1f;
    public  float JumpForce = 50f;
    public  float JumpRalicAdd = 1;

    public  float JumpAdjust = 10f;
  
    public bool OnGround;  
    public  bool SmallSize = false;

    public  bool SizeRalic = false;
    public  bool PowerRlic = false;
    public bool JumpRalic = false;

    private Vector3 HalfeScale = new Vector3(-0.5f, -0.5f, -0.5f);
    private Vector3 FullScale = new Vector3(2f, 2f, 2f);

    private Vector3 PowerSmash = new Vector3(0f, -100f, 0f);

    public ParticleSystem SmashEfect;
   // public ParticleSystem JumpEffect;

    
    private void Start()
    {       
        SmallSize = false;

        if(SizeRalic == true)
        {
            gameObject.transform.localScale = HalfeScale;
            SmallSize = true;
            Speed = 1.5f;
            JumpForce = JumpAdjust * JumpRalicAdd;
        }
    }

    private void Update()
    {
        FallOff();

        SizeChange();
        

        if (Input.GetKeyDown(KeyCode.Space) && OnGround == true)//jump
        {
           /* if (JumpRalic == true)
            {
                JumpEffect.Play();
            }*/
            rb.AddForce(0, JumpForce * JumpRalicAdd , 0, ForceMode.VelocityChange);

            
        }
        else if (Input.GetKeyDown(KeyCode.Space) && OnGround == false && PowerRlic == true)//PowerSmash
        {
            /*if (JumpRalic == true)
            {
                JumpEffect.Play();
            }*/

            PowerJump();

            //Debug.Log(rb.velocity);
        }

    }

    private void FixedUpdate()
    {
        //movement
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, Speed , ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -Speed , ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Speed , 0, 0,ForceMode.VelocityChange);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Speed , 0, 0,ForceMode.VelocityChange);
        }

        rb.AddForce(0, -Gravity , 0, ForceMode.Impulse); // gravity


    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
              
            OnGround = false;   
            
    }

    //SizeRalic Start
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SizeRalic"))
        {
            SizeRalic = true;
            SmallSize = true;
        }

    }

    private void SizeChange()
    {
        if(SizeRalic == true && SmallSize == true && Input.GetKeyDown(KeyCode.F))// SmallSize == true
        {
            gameObject.transform.localScale = FullScale;
            SmallSize = false;
            Speed = 0.3f;
            JumpForce = 4f * JumpRalicAdd;

        }
        else if(SizeRalic == true && SmallSize == false && Input.GetKeyDown(KeyCode.F))//SmallSize == fals
        {
            gameObject.transform.localScale = HalfeScale;
            SmallSize = true;
            Speed =1.5f;
            JumpForce = JumpAdjust * JumpRalicAdd;
        }
    }
    //SizeRalic End


    private void PowerJump()
    {

        rb.AddForce(PowerSmash , ForceMode.VelocityChange);
        Invoke("ParticalPlay", 0.1f);
    }

    private void ParticalPlay()
    {
        SmashEfect.Play();
    }

    private void FallOff()
    {
        if(gameObject.transform.position.y < -20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
