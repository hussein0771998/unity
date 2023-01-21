using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursor1,cursor2, cursor3;
    private Vector2 cursorHotspot;

    // Start is called before the first frame update

    void Start()
    {
        cursorHotspot = new Vector2(cursor1.width * 0.5f, cursor1.height * 0.5f);
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Menu")
        {
            Cursor.SetCursor(cursor1, cursorHotspot, CursorMode.Auto);
        }
        else if (sceneName == "level1")
        {
            Cursor.SetCursor(cursor2, cursorHotspot, CursorMode.Auto);
        }
        else if (sceneName == "Level2")
        {
            Cursor.SetCursor(cursor3, cursorHotspot, CursorMode.Auto);
        }


    }


}
