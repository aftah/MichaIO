using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float rotationSpeed = 30.0f;

    [SerializeField]
    private float speed=2;

    [SerializeField]
    private Transform handL;
    [SerializeField]
    private Transform handR;

    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private int lifePoints;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            Shoot();

            //gameObject.transform.position = Vector3.zero;
        }

        //if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)  )
        //{
        //    MoveLeftHand();
        //}
        //else if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        //{
        //    MoveRightHand();
        //}

        //Debug.DrawLine(gameObject.transform.position, gameObject.transform.forward * 150.0F, Color.red, 5.0F);

    }

    private void MoveRightHand()
    {
       

       // handL.Rotate(handL.transform.rotation.x,handL.transform.rotation.y, OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTrackedRemote));
       
    }

    private void MoveLeftHand()
    {
        //handL.Rotate(handL.transform.rotation.x, handL.transform.rotation.y, OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTrackedRemote));
    }

    private void Shoot()
    {

        RaycastHit raycastHit;

        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out raycastHit, Mathf.Infinity, layerMask))
        {
            Destroy(raycastHit.transform.gameObject);
        }

        Debug.DrawLine(gameObject.transform.position, gameObject.transform.forward * 150.0F, Color.red, 5.0F);

    }

    private void Move()
    {
        float rotZ = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x;
        float posX = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
        float posZ = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y;

        gameObject.transform.Translate(new Vector3(posX, 0, posZ) * speed * Time.deltaTime);

        gameObject.transform.Rotate(Vector3.up * rotZ * rotationSpeed * Time.deltaTime);
    }


}
