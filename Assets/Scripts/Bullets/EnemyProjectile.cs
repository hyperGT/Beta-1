using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    //script do funcionamento do projétil disparado pelo inimigo
    [SerializeField] float speed;
    [SerializeField] float lifeTime;

    
    void Update() => BulletMove();

    void BulletMove(){
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D c){
        if(c.gameObject.layer == 6){
            //hit the player
            Destroy(gameObject);
        }
    }

}
