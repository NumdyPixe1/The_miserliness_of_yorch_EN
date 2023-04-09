using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    Vector2 cursorHotspot;
    public static CursorManager instance;
    public Texture2D cursorTexture;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {

        CursorTest();
    }
    void CursorTest()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        // cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
    }
    void Update()
    {
    }
}
