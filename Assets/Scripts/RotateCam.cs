using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
    public float speed = 2.0f;
    private float yaw = 0.0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            yaw += speed * Input.GetAxis("Mouse X");
            yaw = Mathf.Clamp(yaw, -90.0f, 90.0f);

            transform.eulerAngles = new Vector2(0.0f, yaw);
        }

    }
}
