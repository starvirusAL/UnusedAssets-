using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchPad : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Vector2 origin;
    private Vector2 direction;
    private Vector2 smoothDirection;

    public float smoothing;

    private void Awake()
    {
        direction = Vector2.zero; ;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        origin = eventData.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 curentPosition = eventData.position;
        Vector2 directionRaw = curentPosition - origin;
        direction = directionRaw.normalized;
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        direction = Vector2.zero;
    }
    public Vector2 GetDirection()
    {
        smoothDirection = Vector2.MoveTowards(smoothDirection, direction,smoothing);
        return direction;
    }

}
