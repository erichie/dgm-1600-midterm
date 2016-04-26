using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	// Private variables
	private Rigidbody rb;

	// Public variables
	public float rotateSpeed = 4.0f;
	public float moveSpeed = 10.0f;
	public GameObject bullet;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (new Vector3(0, -rotateSpeed, 0));
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (new Vector3(0, rotateSpeed, 0));;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddRelativeForce(0, 0, moveSpeed);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate(bullet, transform.position, transform.rotation);
		}

	}
 }
