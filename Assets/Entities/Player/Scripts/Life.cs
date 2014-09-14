using UnityEngine;
using System.Collections;

namespace Player {
	public class Life : MonoBehaviour {

		private bool alive;

		public bool Alive {
			get {
				return alive;
			}
		}

		// Use this for initialization
		void Start () {
			alive = true;
		}
		
		// Update is called once per frame
		void OnCollisionEnter () {
			alive = false;
			Time.timeScale = 0;
		}
	}
}
