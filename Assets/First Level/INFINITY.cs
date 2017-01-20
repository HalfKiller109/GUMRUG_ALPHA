using UnityEngine;
using System.Collections;

public class INFINITY : MonoBehaviour {

	// Use this for initialization
	void Start () {


    BoxCollider2D Box = gameObject.GetComponent<BoxCollider2D>();
    Box.size = new Vector2(Mathf.Infinity, 1);
    
}

// Update is called once per frame
void Update () {
	
	}
}
