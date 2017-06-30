using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bifurcator : MonoBehaviour {

	public static GameObject prefab;
	public static bool pause;
	public static GameObject bif;
	public static Killer k;
	public static int count;
	public bool first;
	const float bifurcateChance = 0.0001f;
	public Vector3 direction;
	Color c;
	// Use this for initialization
	void Start () {
		Color[] colors = { Color.black, Color.gray, Color.blue, Color.cyan, Color.red, Color.magenta, Color.yellow };
		count++;
		c = colors [count % colors.Length];
		if (prefab == null) {
			prefab = (GameObject) Resources.Load("Line");
		}	

		if (k == null) {
			k = FindObjectOfType<Killer> ();
		}

		if (bif == null) {
			bif = (GameObject)Resources.Load ("Circle");
		}
		transform.Rotate (direction);
	}
	
	// Update is called once per frame
	void Update () {
		if (!pause) {
			if (Killer.timer > .05f) {
				first = false;
			}
				float step = 1.4f; //* Time.deltaTime;
				transform.position += transform.forward * step;
				GameObject tmp = ((GameObject)Instantiate (prefab));
				tmp.transform.position = this.transform.position;
			tmp.GetComponent<MeshRenderer> ().materials [0].color = c;
			if (!first) {
				if (UnityEngine.Random.Range (0f, 1f) < .01f) {
					bifurcate ();
				}
			}

		}
	}

	void bifurcate() {
		bifurcator tmp = ((GameObject)Instantiate (bif)).GetComponent<bifurcator>();
		tmp.transform.position = this.transform.position;
		tmp.direction = new Vector3 (UnityEngine.Random.Range (0f, 1f), UnityEngine.Random.Range (0f, 1f), 0f);

		tmp = ((GameObject)Instantiate (bif)).GetComponent<bifurcator>();
		tmp.direction = new Vector3 (UnityEngine.Random.Range (.25f, 1f), UnityEngine.Random.Range (.25f, 1f),0f);
		tmp.transform.position = this.transform.position;

		Destroy(this);
	}
}
