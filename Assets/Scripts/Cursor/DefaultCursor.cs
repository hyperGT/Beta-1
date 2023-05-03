using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCursor : MonoBehaviour
{
        
    void Start()
    => Cursor.SetCursor(null, new Vector2(1, 1), CursorMode.Auto);

    
}
