using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
/*
// Code for dropdown button
public class Dropdown : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler

{
    public RectTransform container;
    public bool isOpen;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOpen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOpen = false;
    }

    void Start()
    {

        container = transform.Find("Container").GetComponent<RectTransform>();
        isOpen = false;

    }

    void update()
    {
        // else statement in the if with isOpen ?
        if (isOpen)
        {
            Vector3 scale = container.localScale;
            scale.y = Mathf.Lerp(scale.y, isOpen ? 1;0, Time.deltaTime*12);
            container.localScale = scale; 
        }
    }

}
*/