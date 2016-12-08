﻿using UnityEngine;
using System.Collections;

public class character
{
    
    public new Rigidbody2D rigidbody;
    public new Transform transform;
    public new Animator animator;
    public new Collider2D col_Circle;
    public new Collider2D col_Box;
    public new Collider2D col_Polygon;
    public int direction;
    public float power_Jump;
    public float power_Speed;
    public float mass;
    public float altitude;
    public bool grounded;
}
