using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera> ().fieldOfView--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {            
            GetComponent<Camera>().fieldOfView++;
        }
    }
}