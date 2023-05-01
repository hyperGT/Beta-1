using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    [Header("Camera Settings")]
    private Vector3 mousePos;
 
    
    // Update is called once per frame
    void Update()
    {
        Aim();
    }
    private void Aim()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;                        
    }
}
