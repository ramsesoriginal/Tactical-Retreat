using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	public void now () {
		Time.timeScale = 1;
		Application.LoadLevel ("Game");
		SpawnObstacles.ResetObstacles ();
	}
}
