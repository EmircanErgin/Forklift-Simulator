using System;
using UnityEngine;

    [RequireComponent(typeof (NewCarController))]
public class NewCarUserControl : MonoBehaviour
    {
        private NewCarController m_Car; // the car controller we want to use
    public float Accel;
    public float Steer;
    public float Brake;
   
    public void AccelInput(float input) { Accel = input; }
    public void BrakeInput(float input) { Brake = input; }


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<NewCarController>();
        }


        private void FixedUpdate()
        {
        
        // pass the input to the car!
        //   float h = Input.GetAxis("Horizontal");
        //   float v = Input.GetAxis("Vertical");

        //#if !MOBILE_INPUT
        //float handbrake = Input.GetAxis("Jump");
        m_Car.Move(Steer, Accel, Accel, Brake);

        
        

            
//#else
  //          m_Car.Move(h, v, v, 0f);
//#endif
        }
    }