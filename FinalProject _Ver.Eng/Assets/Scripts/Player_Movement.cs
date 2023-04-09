using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Player_Movement : MonoBehaviour
{
    public float horizontalMove = 0f;

    public float speed = 10f;
    //[SerializeField] private bool crouch = false;
    Animator animator;
    Rigidbody2D rb;
    public AudioSource audioSource;
    public GameManager gameManager;
    private void Awake()
    {
        audioSource.Stop();

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // animator.SetBool("Isgrounded", true);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        //Walk
        if (horizontalMove < -0.1f)//ไปขวา
        {
            //audioSource.Play();
            animator.SetBool("IsWalk", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (horizontalMove > 0.1f)//ไปซ้าย
        {
            // audioSource.Play();
            animator.SetBool("IsWalk", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (horizontalMove == 0f)
        {
            audioSource.Play();
            animator.SetBool("IsWalk", false);
        }
    }
}
































