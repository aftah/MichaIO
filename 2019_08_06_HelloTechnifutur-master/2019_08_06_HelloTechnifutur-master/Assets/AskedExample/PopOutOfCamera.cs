using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopOutOfCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       Vector3 v = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, 1.5f, 10));
       GameObject g= GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g.transform.position = v;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
