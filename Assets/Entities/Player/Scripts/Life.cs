using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections;

namespace Player {
	public class Life : MonoBehaviour {

		private bool alive;

		public bool Alive {
			get {
				return alive;
			}
		}

		public GameObject button;
		public GameObject newHighscore;
		public GameObject newHighscoreImage;

		// Use this for initialization
		void Start () {
			alive = true;
			button.SetActive (false);
		}
		
		// Update is called once per frame
		void OnCollisionEnter () {
			alive = false;
			Time.timeScale = 0;
			button.SetActive (true);
			if (!PlayerPrefs.HasKey ("HighScore") || PlayerPrefs.GetInt ("HighScore") < SpawnObstacles.PassedObstacles) {
				newHighscore.SetActive (true);
				newHighscoreImage.SetActive(true);
				var text = newHighscore.GetComponent<UnityEngine.UI.Text>();
				text.text = "NEW HIGHSCORE!\n\n" + SpawnObstacles.PassedObstacles.ToString();
				PlayerPrefs.SetInt("HighScore",SpawnObstacles.PassedObstacles);
			}

		}
		#if UNITY_EDITOR
		[MenuItem ("Edit/Reset Highscore")]
		public static void resetHighscore() {
			PlayerPrefs.DeleteKey ("HighScore");
		}
		#endif
	}
}
