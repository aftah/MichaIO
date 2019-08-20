using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_ViewportDestroyer : MonoBehaviour
{
    public Transform m_target;
    public Vector2 m_viewport;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_viewport = Camera.main.WorldToViewportPoint(m_target.position);


    }
}
