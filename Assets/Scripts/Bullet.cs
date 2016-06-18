using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public GameObject explosion;
    public GameObject decal;
    public float offset = 0.001f;
    private Quaternion rotation;
    private GameObject tempGameObject;

    void OnCollisionEnter(Collision bulletCollision){

        Destroy(Instantiate(explosion, bulletCollision.contacts[0].point, Quaternion.identity), 2f);
        Destroy(this.gameObject);


        rotation = Quaternion.FromToRotation(-Vector3.forward, bulletCollision.contacts[0].normal);
        tempGameObject = (GameObject)Instantiate(decal, bulletCollision.contacts[0].point, rotation);

        tempGameObject.transform.parent = bulletCollision.gameObject.transform;
        tempGameObject.transform.position = tempGameObject.transform.position + bulletCollision.contacts[0].normal * offset;

        
    }

}