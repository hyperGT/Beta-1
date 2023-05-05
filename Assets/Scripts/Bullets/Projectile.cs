using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //script do funcionamento do projétil disparado pelo player
    void Update() => StartCoroutine(destroyProjectile());
    IEnumerator destroyProjectile()
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }


}
