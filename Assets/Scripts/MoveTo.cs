using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public GameObject[] cube;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (cube[1].transform == hit.transform)
                {
                    cube[0].transform.position = Vector3.MoveTowards(cube[0].transform.position, cube[1].transform.position, speed * Time.deltaTime);
                }
                else if (cube[2].transform == hit.transform)
                {
                    cube[0].transform.position = Vector3.MoveTowards(cube[0].transform.position, cube[2].transform.position, speed * Time.deltaTime);
                }
            }
        }
    }
}
