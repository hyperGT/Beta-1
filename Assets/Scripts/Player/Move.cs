using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Player Move Config")]
    [SerializeField]
    private float moveSpeed;
    private Rigidbody2D rb;

    [Header("Player Animations")]
    private Animator anim; 
    private SpriteRenderer spriteRenderer; // player sprite renderer

    [Header("Weapon move by code")]
    public SpriteRenderer weaponPhase; //get the sprite rederer by the weapon object    
    public Transform posicao1;
    public Transform posicao2;
    public Transform shotPosition; 


    private Vector2 moveDirection;   

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        weaponPhase = GameObject.FindGameObjectWithTag("Weapon").GetComponent<SpriteRenderer>();
        shotPosition = GameObject.FindGameObjectWithTag("BulletSpawn").GetComponent<Transform>();
        weaponPhase.flipY = false;
    }

    
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        //if press 'A', return 1, if 'D', return -1, if nothing, return 0.
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
        if (moveDirection != Vector2.zero)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }

        if (moveDirection.x < 0)
        {
            spriteRenderer.flipX = true;
            weaponPhase.flipY = true;
            shotPosition.position = Vector2.MoveTowards(shotPosition.position, posicao2.position, 20 * Time.deltaTime); 
        }
        else if(moveDirection.x > 0)
        {
            spriteRenderer.flipX = false;            
            weaponPhase.flipY = false;
            shotPosition.position = Vector2.MoveTowards(shotPosition.position, posicao1.position, 20 * Time.deltaTime);
        }
    }

    //is called once per physics
    void FixedUpdate() => 
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
}
