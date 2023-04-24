using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static float AngleTowardsMouse(Vector3 pos)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objektPos = Camera.main.WorldToScreenPoint(pos);
        mousePos.x = mousePos.x - objektPos.x;
        mousePos.y = mousePos.y - objektPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        return angle;
    }
}
