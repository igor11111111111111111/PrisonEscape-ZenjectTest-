using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DigButton : Button
{
    public Action<bool> OnPressed;

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        OnPressed?.Invoke(true);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        OnPressed?.Invoke(false);
    }
}
