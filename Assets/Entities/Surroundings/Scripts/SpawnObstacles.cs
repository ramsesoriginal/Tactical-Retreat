using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour {

	public GameObject Obstacle;
	public float heigthVariance = 5;
	public float distance = 15;
	public float randomDistance = 4;

	private static int passedObstacles;

	static SpawnObstacles() {
		passedObstacles = 0;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		var x = transform.position.x + distance + Random.Range(0,randomDistance);
		var y = Random.Range((-heigthVariance/2f), (heigthVariance/2f));
		var z = 0;
		var t = (GameObject)Instantiate (Obstacle, new Vector3 (x, y, z), transform.rotation);
		t.transform.parent = transform.parent;
		passedObstacles++;
	}
}
