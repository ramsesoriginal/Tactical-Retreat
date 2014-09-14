using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetScore : MonoBehaviour {

	public Text scoreDisplay;

	// Use this for initialization
	void Start () {
		scoreDisplay = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreDisplay.text = SpawnObstacles.PassedObstacles.ToString();

		if (PlayerPrefs.HasKey ("HighScore")) {
			scoreDisplay.text += "<size=8>\n\nhighscore: " + PlayerPrefs.GetInt("HighScore").ToString() + "</size>";
		}
	}
}
