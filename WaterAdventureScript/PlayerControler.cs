using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody2D rbody;
    private CapsuleCollider2D cCollider;
    private bool isOnGround=true;
    public float speed;
    public float distanceRay;
    private Animator anim;
    private float maxHealth=100;
    public float MyMaxHealth
    {
        get { return maxHealth; }
    }
    private float currentHealth;
    public float MyCurrentHealth
    {
        get { return currentHealth; }
    }

    public float sped=10;
    public GameObject set;
    private AudioSource jumpVoice;
    public AudioSource faultVoice;
    public AudioSource nia;
    public AudioSource reduceNia;
    public float reduce;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jumpVoice = GetComponent<AudioSource>();
        HealthBar.Instance.changeHealth();//单例
        StartCoroutine("ReduceHealthEverySecond");
        AudioSource faultVoices = faultVoice.GetComponent<AudioSource>();
    }

    IEnumerator ReduceHealthEverySecond()
    {
        while (true)
        {
            currentHealth -=reduce;
            HealthBar.Instance.changeHealth();
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetBool("itow",false);
        anim.SetBool("itoj",false);
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            
            transform.Translate(Vector2.right*horizontal*Time.deltaTime);
            GetComponent<SpriteRenderer>().flipX = horizontal > 0 ? false : true;
            anim.SetBool("itow",true);
            anim.SetBool("wtoj",false);
            anim.SetBool("itoj",false);
        }

        Ray2D rayVer = new Ray2D(this.transform.position, Vector2.down);//从自身位置向下发射一条射线；
        RaycastHit2D rayInfoVer = Physics2D.Raycast(rayVer.origin, rayVer.direction,distanceRay);
        Debug.DrawRay(rayVer.origin,rayVer.direction,Color.red,distanceRay);
        
        if (rayInfoVer.collider != null)
        {
            if (rayInfoVer.transform.gameObject.CompareTag("Ground"))
            {
                Debug.Log("检测到地面");
                isOnGround = true;
            }
        }
        else
        {
            Debug.Log("没有检测到地面");
            isOnGround = false;
        }

        float vertical = Input.GetAxis("Vertical");
        if (vertical>0&&isOnGround==true)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, speed * Time.deltaTime);
            jumpVoice.Play();
            anim.SetBool("itoj",true);
            anim.SetBool("itow",false);
            anim.SetBool("wtoj",true);
        }

        if (vertical < 0)
        {
            
        }

        if (MyCurrentHealth == 0)
        {
            death();
        }

        //自身每秒失血量
        

    }

    public void ReduceHealth(float health)
    {
        currentHealth = Mathf.Clamp(currentHealth - health, 0, maxHealth);
        HealthBar.Instance.changeHealth();
        reduceNia.GetComponent<AudioSource>().Play();
    }

    public void AddHealth(float health)
    {
        currentHealth = Mathf.Clamp(currentHealth + health, 0, maxHealth);
        HealthBar.Instance.changeHealth();
        nia.GetComponent<AudioSource>().Play();
    }
    
    public void death()
    {
        Setup sets = set.GetComponent<Setup>();
        if (currentHealth == 0)
        {
            sets.ShowPanel();
            faultVoice.Play();
        }
    }
}
