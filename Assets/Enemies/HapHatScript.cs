using UnityEngine;
using System.Collections;

public class HapHatScript : MonoBehaviour {

    public float playerTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform playerTarget;
    Rigidbody2D theRigidbody;
    Renderer myRender;


	// Use this for initialization
	void Start () {
        myRender = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        playerTargetDistance = Vector2.Distance(playerTarget.position, transform.position);
        if (playerTargetDistance < enemyLookDistance)
            {
            lookatPlayer();
        }
        if (playerTargetDistance < attackDistance)
        {
            attackPlease();
        }

        }
        void lookatPlayer()
            {
        Quaternion rotation = Quaternion.LookRotation(playerTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        }
    void attackPlease()
    {
        theRigidbody.AddForce(transform.forward * enemyMovementSpeed);
    }
	}

