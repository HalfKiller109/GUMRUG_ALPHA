using UnityEngine;
using System.Collections;

public class HapHatScript : MonoBehaviour
{
    public character HapHat = new character();
    
    [SerializeField]
    float SizeOfTerritory;

    [SerializeField]
    LayerMask Layer;

    [SerializeField]
    Transform CenterOfHapHat;

    //public float playerTargetDistance;
    // public float enemyLookDistance;
    // public float attackDistance;
    // public float enemyMovementSpeed;
    // public float damping;
    // public Transform playerTarget;
    //public float HapHat;

    character Hero_Test = new character(); 
    void Start()
        {
        HapHat.rigidbody = gameObject.GetComponent<Rigidbody2D>();
        HapHat.transform = gameObject.GetComponent<Transform>();
        HapHat.animator = gameObject.GetComponent<Animator>();
        HapHat.col_Circle = gameObject.GetComponent<CircleCollider2D>();
        HapHat.col_Polygon = gameObject.GetComponent<PolygonCollider2D>();
        Hero_Test.col_Box = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        Hero_Test.transform = gameObject.GetComponent<Transform>();
        HapHat.power_Speed = 3;
        HapHat.power_Jump = 500;


    }

    void Move()
    {
        
        if (HapHat.col_Circle.bounds.Intersects(Hero_Test.col_Box.bounds))
        {
            Debug.Log("I see you....");
            if (HapHat.transform.position.x > Hero_Test.transform.position.x)
            {
               
                HapHat.animator.SetInteger("Direction", 1);
                HapHat.rigidbody.velocity = new Vector2(HapHat.power_Speed, HapHat.rigidbody.velocity.y);

            }
            if (HapHat.transform.position.x < Hero_Test.transform.position.x)
            {
                HapHat.animator.SetInteger("Direction", 0);
                HapHat.rigidbody.velocity = new Vector2(-HapHat.power_Speed, HapHat.rigidbody.velocity.y);

            }
        }
        else
        {
            Debug.Log("I will find you. I will make you my best friend.");
        }

        if (HapHat.col_Polygon.bounds.Intersects(Hero_Test.col_Box.bounds))
        {
            Debug.Log("Attack!");
        }
    }
 
    void Update()
    {

        Move();
        
        //gameObject.GetComponent<SpriteRenderer>().flipX = true;


    }

}

     


 