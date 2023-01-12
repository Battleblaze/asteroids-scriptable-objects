using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEngine;
using Variables;

[CreateAssetMenu]
public class ShipType : ScriptableObject
{
        public int health;
        
        public float _throttlePower;
        public float _rotationPower;
}
