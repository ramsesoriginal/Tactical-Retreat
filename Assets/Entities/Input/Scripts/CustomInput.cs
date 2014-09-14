using UnityEngine;
using System.Collections;

namespace CustomInput {
	public class CustomInput : MonoBehaviour {

		public static CustomInput input;

		private bool pressed;

		public bool Active {
			get {
				return pressed;
			}
		}

		public Transform position;

		// Use this for initialization
		void Start () {
			CustomInput.input = this;
		}
		
		// Update is called once per frame
		void Update () {
			pressed = position.position.z == 1;
		}
	}
}