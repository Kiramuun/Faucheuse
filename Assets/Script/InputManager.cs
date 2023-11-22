using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Vector3 mousePosInGame;

    void Update()
    {
        trackMousePos();
    }

    void trackMousePos()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePosInGame=new Vector3(mousePos.x, mousePos.y, mousePos.z*-1);
        mousePosInGame= Camera.main.ScreenToWorldPoint(mousePosInGame);
    }
}
