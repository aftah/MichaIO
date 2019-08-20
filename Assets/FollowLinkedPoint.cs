using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLinkedPoint : MonoBehaviour
{

    public Transform mTarget;
    
    void LateUpdate()
    {
        transform.position = mTarget.position;
        transform.rotation = mTarget.rotation;
    }
}
