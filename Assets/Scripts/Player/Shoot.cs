using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("Bullet Settings")]
    private Transform firePoint;   
    public GameObject bulletPrefab;
    public bool reloading; //verifica se pode disparar
    [SerializeField] private float bulletForce;
                           

    // Start is called before the first frame update
    void Start()
    {        
        firePoint = GameObject.FindGameObjectWithTag("BulletSpawn").GetComponent<Transform>();        

    }

    // Update is called once per frame
    void Update()
    {        
        
             
        if (Input.GetButtonDown("Fire1"))
        {
            Shooting();
        }       
    }   


    private void Shooting()
    {     
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    
    
}