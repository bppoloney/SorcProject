using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public int value;
	public int weight;
	public string itemName;

	public void DefineItem(string s, int v, int w) {
		itemName = s;
		name = s;
		value = v;
		weight = w;
	}
}
