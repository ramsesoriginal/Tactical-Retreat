using UnityEngine;
using System.Collections;

namespace Player {
	public class Accelerate : MonoBehaviour {

		public float speed = 10;

		// Update is called once per frame
		void Update () {
			//rigidbody.velocity = new Vector3 (0,0, rigidbody.velocity.z, rigidbody.velocity.z);
			//Debug.Log (transform.InverseTransformDirection(rigidbody.velocity));
			if (transform.InverseTransformDirection(rigidbody.velocity).x < speed)
				rigidbody.AddForce (Vector3.right * speed * Time.deltaTime,ForceMode.VelocityChange);
		}
	}
}