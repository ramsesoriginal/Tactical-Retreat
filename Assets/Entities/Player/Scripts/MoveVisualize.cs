using UnityEngine;
using System.Collections;

namespace Player {
	public class MoveVisualize : MonoBehaviour {

		public GameObject playerCollider;

		public float AnimationSpeed = 1;
		public float VerticalExageration = 2;

		// Update is called once per frame
		void Update () {
			transform.position = playerCollider.transform.position;
			transform.forward = Vector3.Lerp(transform.forward, new Vector3(playerCollider.rigidbody.velocity.x, playerCollider.rigidbody.velocity.y * VerticalExageration, playerCollider.rigidbody.velocity.z),AnimationSpeed * Time.deltaTime);
		}
	}
}
