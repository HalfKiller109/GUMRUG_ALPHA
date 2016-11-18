using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {

     

}
    public GameObject SpawnPoint;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Death Animation")
        {
            this.transform.position = SpawnPoint.transform.position;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
