using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
  private Camera Playercamera;
   private void Start()
    {
        Playercamera = Camera.main;
    }

    // Update is called once per frame
   private void FixedUpdate()
    {
        LookAtPlayer();
    }
   private void LookAtPlayer(){
        transform.LookAt(transform.position+ Playercamera.transform.rotation * Vector3.forward,Playercamera.transform.rotation* Vector3.up);
    }
}
