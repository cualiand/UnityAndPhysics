using UnityEngine;
using System.Collections;

public class disableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
        }
	}
}
