using UnityEngine;
using System.Collections;

public class rigidbodyController : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rBody;

    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 forwardForce = transform.forward * Time.deltaTime * speed * vertical;
        rBody.AddForce(forwardForce);
        //for physics forces, do it in fixedupdate

        transform.Rotate(0f, horizontal * 90f * Time.deltaTime, 0f);
    }
}