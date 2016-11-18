using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public character hero_Test = new character();

    // Use this for initialization
    void Start () {

        hero_Test.rigidbody = gameObject.GetComponent<Rigidbody2D>();
       

    }
    public GameObject SpawnPoint;
    
   
    // Update is called once per frame
    void Update ()
    {
        Debug.Log(gameObject.GetComponent<BoxCollider2D>().transform.tag);
       if ( gameObject.GetComponent<BoxCollider2D>().transform.tag == "Player")
        {
            hero_Test.rigidbody.velocity = 
            hero_Test.rigidbody.position = new Vector2(-29.14f, -1.4f);
        }
	}
}
