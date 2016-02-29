using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour {

    CharacterController myController;
    public float speed = 5f;

	// Use this for initialization
	void Start () {
        myController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal"); //simulating a virtual joystick from -1  to 1, 0 means no movement
        float vertical = Input.GetAxis("Vertical");

        //do movement now
        Vector3 movement = transform.forward * speed * vertical * Time.deltaTime;
        myController.Move(movement + Physics.gravity * Time.deltaTime);

        //do turning now
        transform.Rotate(0f, horizontal * 90f * Time.deltaTime, 0f);
        //note this does physically impossible things, like stopping instantly
        //also doesn't deal with other physics objects in the environment
	}
}
