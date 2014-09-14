using UnityEngine;
using System.Collections;

namespace CustomInput {
	public class KeyboardDown : MonoBehaviour {

		// Update is called once per frame
		void Update () {
			if (Input.anyKey) {
				transform.position = new Vector3 (0, 0, 1);
			} else {
				transform.position = new Vector3 (0, 0, 0);
			}
		}
	}
}