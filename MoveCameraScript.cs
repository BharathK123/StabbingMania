using UnityEngine;
using System.Collections;

public class MoveCameraScript : MonoBehaviour {

	private int MaxVel = 6;
	private float CharRotationSpeed = 150f;
	private Rigidbody rbody;

	void Start () {
		rbody = GetComponent<Rigidbody> ();
	}
	void Update () {

		if (Input.GetKey(KeyCode.RightArrow)) {
			rbody.velocity = gameObject.transform.right * MaxVel;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			rbody.velocity = gameObject.transform.right * -1 * MaxVel;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			rbody.velocity = gameObject.transform.forward * MaxVel;
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			rbody.velocity = gameObject.transform.forward * -1 * MaxVel;
		}

		// Key up
		if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow)) {
			rbody.velocity = Vector3.zero;
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow)) {
			rbody.velocity = Vector3.zero;
		}

		//Rotate
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up, -CharRotationSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up, CharRotationSpeed * Time.deltaTime);
		}
	}

}