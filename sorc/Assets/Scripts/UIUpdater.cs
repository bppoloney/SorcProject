using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIUpdater : MonoBehaviour {

	private Text moneyDisplay;
	private Text energyDisplay;

	// Use this for initialization
	void Awake () {
		moneyDisplay = GameObject.Find ("Canvas/HeaderBar/Money").GetComponent<Text>();
		energyDisplay = GameObject.Find ("Canvas/HeaderBar/Energy").GetComponent<Text> ();
	}

	public void UpdateMoney(int s) {
		moneyDisplay.text = "Money: $" + s.ToString ();;
	}

	public void UpdateEnergy(int s) {
		energyDisplay.text = "Energy: " + s.ToString();
	}
}
