using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Runtime.InteropServices;

/**
 * @CursorManager
 * Gerenciador de Cursor de mouse
 */

public class CursorManager : MonoBehaviour
{  
    [Header("Cursor Texture")]    
    [SerializeField] private Texture2D[] cursorTextureArray;
    
    [Header("Cursor Animation Config")]
    [SerializeField] private int frameCount;
    [SerializeField] private float frameRate;

    private int currentFrame;
    private float frameTimer;

    void Start() => Cursor.SetCursor(cursorTextureArray[0], new Vector2(16, 16), CursorMode.Auto);


    void Update() => AimAnimation();

    private void AimAnimation()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0f)
        {
            frameTimer += frameRate;
            currentFrame = (currentFrame + 1) % frameCount;
            Cursor.SetCursor(cursorTextureArray[currentFrame], new Vector2(16, 16), CursorMode.Auto);
        }
    }
}
