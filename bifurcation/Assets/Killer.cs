using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour {
	public static float timer;
	static GameObject prefab;
	bool doOnce;
	// Use this for initialization
	void Start () {

		timer = 0f;
		prefab = (GameObject)Resources.Load ("Circle");
	}
	
	// Update is called once per frame
	void Update () {
		if (!bifurcator.pause) {
			timer += Time.deltaTime;
			if (timer > 10f) {
				if (!doOnce) {
					bifurcator.pause = true;
					doOnce = true;
				} else {
					GameObject[] g = GameObject.FindGameObjectsWithTag ("Finish");
					foreach (GameObject gs in g) {
						Destroy (gs);
					}
					GameObject tmp = (GameObject)Instantiate (prefab);
					tmp.transform.position = new Vector3 (-7.52f, 4.28f, 0f);
					bifurcator b = tmp.GetComponent<bifurcator> ();
					if (b != null) {
						b.first = true;
					}
					timer = 0f;
					doOnce = false;
				}
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			bifurcator.pause = !bifurcator.pause;
		}
	}
}
