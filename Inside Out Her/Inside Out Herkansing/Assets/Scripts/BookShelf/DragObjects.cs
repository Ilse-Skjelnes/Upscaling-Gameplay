using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;
    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord; 

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    private void OnMouseDrag()
    {

        
        transform.position = GetMouseWorldPos() + mOffset;
    }
}
