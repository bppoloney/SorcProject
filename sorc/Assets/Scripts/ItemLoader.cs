using UnityEngine;
using System.Collections.Generic;

public class ItemLoader : MonoBehaviour {

	private List<Item> items;
	private GameObject itemPrefab;

	// Use this for initialization
	void Start () {
		itemPrefab = (GameObject)Resources.Load ("Item");
		items = new List<Item> ();

		GameObject tmp = Instantiate (itemPrefab);
		tmp.transform.SetParent (this.transform);
		Item tmpItem = tmp.GetComponent<Item>();
		tmpItem.itemName = "Test Item";
		tmpItem.value = 100;
		items.Add (tmpItem);
	}
	
	private void LoadItem(string s, int i) {
		GameObject tmp = Instantiate (itemPrefab);
		tmp.transform.SetParent (this.transform);
		Item tmpItem = tmp.GetComponent<Item>();
		tmpItem.itemName = s;
		tmp.name = s;
		tmpItem.value = i;
		items.Add (tmpItem);
	}
}
