using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelocateCube : MonoBehaviour
{
    public Transform target;
    public Transform cubemirror;
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cubemirror.localPosition = camera.InverseTransformPoint(target.position);
        Debug.DrawLine(Vector3.zero, cubemirror.position, Color.red);
    }
}
