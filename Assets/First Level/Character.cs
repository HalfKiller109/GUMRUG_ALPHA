using UnityEngine;
using System.Collections;

public class character
{
    
    public Rigidbody2D rigidbody;
    public Transform transform;
    public Animator animator;
    public Collider2D col_Circle;
    public Collider2D col_Box;
    public Collider2D col_Polygon;
    public int direction;
    public float power_dashingSpeed;
    public float power_Jump;
    public float power_Speed;
    public float mass;
    public float altitude;
    public bool grounded;
}
