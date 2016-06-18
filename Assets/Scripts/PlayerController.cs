using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speedTranslation;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float speedRotation = 50;
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float mouseX = Input.GetAxis("Mouse X");
        float turbo = 1;

        if (Input.GetKey(KeyCode.Space))
            turbo = 2;
        else
            turbo = 1;
        transform.Rotate(Vector3.up * speedRotation * Time.deltaTime * mouseX);
        transform.Translate(Vector3.forward * vertical * Time.deltaTime * speedTranslation * turbo);
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speedTranslation * turbo);

        float angle = transform.localEulerAngles.y;

        if (Mathf.Abs(vertical) > 0 || Mathf.Abs(horizontal) > 0){


        }
    }
}
