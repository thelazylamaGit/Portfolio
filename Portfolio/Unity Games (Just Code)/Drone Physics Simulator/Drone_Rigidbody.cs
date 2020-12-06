using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DroneGame
{
    [RequireComponent(typeof(Rigidbody))]
    public class Drone_Rigidbody : MonoBehaviour
    {
        #region Variables
        [Header("Rigidbody Properties")]
       [SerializeField] private float weightInKgs = 1f; 

        protected Rigidbody rb;
        protected float startDrag;
        protected float startAngluarDrag;
        #endregion

        #region Main Methods
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.mass = weightInKgs;
                startDrag = rb.drag;
                startAngluarDrag = rb.angularDrag;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (!rb)
            {
                return;
            }

            HandlePhysics();
        }
        #endregion

        #region Custom Methods
        protected virtual void HandlePhysics() { }
        #endregion
    }
}
