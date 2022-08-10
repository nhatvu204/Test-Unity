using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    public GameObject dragObj;
    public LayerMask layerMask;
    public bool isDragging;
    void Start()
    {
        isDragging = true;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
        if (isDragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, layerMask))
            {
                dragObj.transform.position = hit.point + new Vector3(0, 0.5f, 0);
            }
        }
    }
}
