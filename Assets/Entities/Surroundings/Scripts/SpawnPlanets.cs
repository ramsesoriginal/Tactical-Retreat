using UnityEngine;
using System.Collections;

public class SpawnPlanets : MonoBehaviour {

	public float minSize;
	public float maxSize;
	public float near;
	public float far;
	public float bottom;
	public float top;

	public GameObject Spawner;
	public GameObject Planet;

	public Transform Planets;

	void Start() {
		Planets = GameObject.FindWithTag ("Planets").transform;
	}

	// Update is called once per frame
	void OnTriggerEnter () {
		var x = transform.position.x + 250;
		var z = Random.Range(near, far);
		var y = Random.Range(bottom*(z/10), top*(z/10));
		var p = (GameObject)Instantiate (Planet, new Vector3 (x, y, z), transform.rotation);
		var scale = Random.Range (minSize, maxSize);
		p.transform.localScale = new Vector3 (scale, scale, scale);
		p.transform.parent = Planets;
		var s = (GameObject)Instantiate (Spawner, transform.position, transform.rotation);
		s.transform.parent = transform.parent;

	}
}
