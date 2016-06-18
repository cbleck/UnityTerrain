using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

    public Rigidbody cubeRigidBody;

	// Use this for initialization
	void Start () {

        cubeRigidBody = GetComponent<Rigidbody>();
	
	}

    void OnCollisionEnter(Collision collisionObject)
    {

        if (collisionObject.transform.tag == "CameraController")
            GetComponent<MeshRenderer>().material.color = Color.red;
    }
    void OnCollisionStay(Collision collisionObject) {

        if(collisionObject.transform.tag == "CameraController")
            GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    void OnCollisionExit(Collision collisionObject)
    {
        if (collisionObject.transform.tag == "CameraController")
            GetComponent<MeshRenderer>().material.color = Color.white;
    }

    void OnControllerColliderHit(ControllerColliderHit colliderhit) {
        if (colliderhit.transform.tag == "CameraController")
            GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
