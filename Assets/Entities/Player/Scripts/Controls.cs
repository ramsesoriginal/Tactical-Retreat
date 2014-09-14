using UnityEngine;
using System.Collections;

namespace Player {
	public class Controls : MonoBehaviour {

		public float force = 10;

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if (CustomInput.CustomInput.input.Active) {
				rigidbody.AddForce(Vector3.up * force);
			}
		}
	}
}