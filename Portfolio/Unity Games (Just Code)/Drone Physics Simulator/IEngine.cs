using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DroneGame
{
    public interface IEngine
    {
        void InitEngine();
        void UpdateEngine(Rigidbody rb, Drone_Inputs input);
    }
}
