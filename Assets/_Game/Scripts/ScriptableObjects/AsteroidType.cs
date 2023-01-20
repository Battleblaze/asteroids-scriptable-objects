using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class AsteroidType : ScriptableObject
{
    [SerializeField] public float _minForce;
    [SerializeField] public float _maxForce;
    [SerializeField] public float _minSize;
    [SerializeField] public float _maxSize;
    [SerializeField] public float _minTorque;
    [SerializeField] public float _maxTorque;
    [SerializeField] public Vector2 _force;

    public float damage;
    public Color color;

}
