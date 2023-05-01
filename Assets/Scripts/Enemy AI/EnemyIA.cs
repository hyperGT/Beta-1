using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float StopDistance;
    [SerializeField] private float MoveTime;

    [Header("Obj. Components")]
    [SerializeField] Transform Target; // catch the player position
    [SerializeField] EnemyProjectile Bullet; // bullet prefab

    [Header("Attack Mechanics")]
    [SerializeField] GameObject Player; // catch the player game object
    [SerializeField] private float ShotSpeed;
    [SerializeField] private float Timer;
    [SerializeField] private float RangeAttack;



    void Start() 
    { 
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Player = GameObject.FindGameObjectWithTag("Player");
        //Invoke(nameof(Move), 2.5f);
    }

    void Update()
    {
        Shoot();
        StartCoroutine(Move());
    }

    // enemy movement 
    IEnumerator Move()
    {
        //
        if (Vector2.Distance(transform.position, Target.position) > StopDistance)
        {
            // activate animation

            //moving to target position
            
            transform.position = Vector2.MoveTowards(transform.position, Target.position, MoveSpeed * Time.deltaTime);
        }
        yield return new WaitForSeconds(MoveTime);
    }

    //enemy hostile attack
    private void Shoot()
    {
        //detect player movement
        if (Player != null)
        {
            //shoot in player direction
            transform.up = (Vector2)Player.transform.position - (Vector2)transform.position;
            if (Timer > 0) Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                if (Bullet != null)
                {
                    EnemyProjectile newBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
                    newBullet.transform.localPosition = transform.position;
                    newBullet.transform.rotation = transform.rotation;
                }
                Timer = ShotSpeed;
            }
        }
        //reset player detection when player leaves the detection radius
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.layer == 6) Player = c.gameObject;
    }
    void OnTriggerExit2D(Collider2D c)
    {
        if (c.gameObject.layer == 6) Player = null;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, RangeAttack);
    }
}