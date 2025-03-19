using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bullet")]
public class Bullet : ScriptableObject
{
    public float Speed;
    public Vector3 Scale;
    public Color Color;
    public float Force;
}
