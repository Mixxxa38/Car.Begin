using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
   [SerializeField] 
   private float _speed;
   private void Update()
   {
       var position = transform.position;

       var step = _speed * Time.deltaTime;

       if (Input.GetKey(KeyCode.W))
       {
           position.z += step;
       }
       
       else if (Input.GetKey(KeyCode.S))
       {
           position.z -= step;
       }
       
       else if (Input.GetKey(KeyCode.A))
       {
           position.x -= step;
       }

       else if (Input.GetKey(KeyCode.D))
       {
           position.x += step;
       }
       
       transform.position = position;
   }
}
