using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	const int MAX_ENERGY = 100;

	private int money;
	private int energy;

	private UIUpdater ui;

	// Use this for initialization
	void Start () {
		ui = GameObject.FindObjectOfType<UIUpdater> ();
		SetMoney (0);
		SetEnergy (MAX_ENERGY);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Rest() {
		SetEnergy (MAX_ENERGY);
	}

	public void Ex() {
		SetEnergy (energy - 10);
	}

	public void SetMoney(int i) {
		money = i;
		ui.UpdateMoney (money);
	}


	public int GetMoney() {
		return money;
	}

	public void SetEnergy(int i) {
		energy = i;
		ui.UpdateEnergy (energy);
	}

	public int GetEnergy() {
		return energy;
	}
}
