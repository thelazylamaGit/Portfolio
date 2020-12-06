using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DroneGame
{
    [RequireComponent(typeof(Drone_Inputs))]
    [RequireComponent(typeof(BoxCollider))]
    public class Drone_Engine : MonoBehaviour, IEngine
    {
        #region Variables
        [Header("Engine Properties")]
        [SerializeField] private float maxPower = 4f;

        [Header("Propeller Properties")]
        [SerializeField] private Transform propeller = null;
        [SerializeField] private float propRotSpeed = 0f;
        private Transform Drone;
        private float distToGround = 0.05f;
        #endregion

        #region interface Methods
        public void Start()
        {
            //Gets Drone Transform
            Drone = GameObject.Find("Drone").transform;
        }

        public void InitEngine()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEngine(Rigidbody rb, Drone_Inputs input)
        {
            //Debug.Log("Running Engine: " + gameObject.name);
            Vector3 upVec = transform.up;
            upVec.x = 0f;
            upVec.z = 0f;
            float diff = 1 - upVec.magnitude;
            float finalDiff = Physics.gravity.magnitude * diff;

            Vector3 engineforce = Vector3.zero;
            engineforce = transform.up * ((rb.mass * Physics.gravity.magnitude + finalDiff) + (input.Throttle * maxPower)) / 4f;

            rb.AddForce(engineforce, ForceMode.Force);
            HandlePropellers(input);
            /*Fix This ^^^^^^
             * 
             * Also try to lerp between the proppelers rotating on and off
             * when the engine stops
             * 
             * Try make the controllers better for racing (more responsive)
             * 
             * make it so you can change directions quicker
             * 
             * Add tricks like flips and stuff
             * 
             * add time trial mechanics (timer, goals, sound effects, particles, music, etc)
             * 
             * Make trello page instead of using comments in code
             * 
             * add more drone models
             * 
             * add split screen
             * 
             * add power ups
             * 
             * Possibly add weapons
             */

        }

        void HandlePropellers(Drone_Inputs input)
        {
            if (!propeller)
            {
                return;
            }
            propeller.Rotate(Vector3.up, propRotSpeed);
        }

        bool isGrounded()
        {
            return Physics.Raycast(Drone.transform.position, Vector3.down, distToGround);
        }
        #endregion
    }
}
