using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandRotation : MonoBehaviour
{
    
    public Transform refPoint;
    public Transform playerHand;

   
    public Vector3 cameraToHandOffsetPosition;
    public Vector3 cameraToHandOffsetEuler;


   
    public Transform handToAffect;
    public float angleHorizontal = 90;
    public float angleVertical = 90;
   


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraToHandOffsetPosition = refPoint.InverseTransformPoint(playerHand.position);

        // Quaternion localRotation = Quaternion.Euler(-angleVertical * Mathf.Clamp(cameraToHandOffsetPosition.y, -1, 1), -angleHorizontal * Mathf.Clamp(cameraToHandOffsetPosition.x, -1, 1), 0);

        Quaternion localRotation = Quaternion.Euler(-angleVertical * cameraToHandOffsetPosition.y, -angleHorizontal * cameraToHandOffsetPosition.x, 0); cameraToHandOffsetEuler = localRotation.eulerAngles;        

        handToAffect.localRotation = localRotation;
    }
}
