using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
int health= 100;
int damage;
Random dmgroll;
int armor=1;

	public Text text; 
	// Use this for initialization
	void Start () {
	text.text="Hello World";
	}
	
	// Update is called once per frame
	void Update () {
		 if(Input.GetKeyDown(KeyCode.Space))
		 {
		 text.text="You watch from the tavern window as dusk falls over the town of DawnLake." + 
		 " In a past life you were a knight errant, but now the only life you know is that of a mecenary." +
		 " Your purse is light of coin, and your sheath weighs heavy \n\n" +
		 " You may:  D: Drink.  V: View   C: ask about rumors and gossip";
		 
	}
	}
}
