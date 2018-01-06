using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {

    [Range(-1f, 1.5f)]
    public float walkSpeed;

	// Use this for initialization
	void Start () {
        Rigidbody2D myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        myRigidbody.isKinematic = true;
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
	}

    void OnTriggerEnter2D() {
        Debug.Log(name + " trigger entered");
    }
}
