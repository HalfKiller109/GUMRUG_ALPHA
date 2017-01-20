using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NewBehaviourScript3 : MonoBehaviour {

	public void Button(string FirstLevel)
    {
        SceneManager.LoadScene(FirstLevel);
    }
}
