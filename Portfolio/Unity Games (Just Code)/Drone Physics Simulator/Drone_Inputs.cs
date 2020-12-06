using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DroneGame
{
    [RequireComponent(typeof(PlayerInput))]
    public class Drone_Inputs : MonoBehaviour
    {
        #region variables

        private Vector2 cyclic;
        private float pedals;
        private float throttle;
        private float killEngine;
        private bool engineOn = true;

        public Vector2 Cyclic { get => cyclic; }
        public float Pedals { get => pedals; }
        public float Throttle { get => throttle; }
        public float KillEngine { get => KillEngine; }
        public bool EngineOn { get => engineOn; set => engineOn = value; }
        #endregion

        #region Main Methods
        void Update()
        {

        }
        #endregion
        #region Input Methods
        private void OnCyclic(InputValue value)
        {
            cyclic = value.Get<Vector2>();
        }

        private void OnPedals(InputValue value)
        {
            pedals = value.Get<float>();
        }

        private void OnThrottle(InputValue value)
        {
            throttle = value.Get<float>();
        }
        private void OnKill_Engine (InputValue value)
        {
           float killEngine = value.Get<float>();
            if(killEngine == 0)
            {
                EngineOn = true;
            }
            else
            {
               EngineOn = false;
            }
        }
        #endregion
    }
}
