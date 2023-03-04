using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // make an object rotate
        transform.Rotate(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // make the object rotate faster when its clicked
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, 10);
        }
    }
}
