using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Inventory class is used to generate the database of items
/// </summary>
public class Inventory : MonoBehaviour {

	public List<Item> items;
	private static GameObject itemPrefab;

	// Use this for initialization
	void Start () {
		items = new List<Item>();
		itemPrefab = (GameObject)Resources.Load ("Prefabs/Item");

		Item[] presets = GetComponentsInChildren<Item> ();
		foreach (Item i in presets) {
			items.Add (i);
		}

		LoadItems ();
	}

	private void LoadItems() {
		GameObject tmp = Instantiate (itemPrefab);
		tmp.transform.SetParent (this.transform);
		tmp.GetComponent<Item> ().DefineItem ("Test Item", 1, 1);
		items.Add(tmp.GetComponent<Item>());
	}
}
