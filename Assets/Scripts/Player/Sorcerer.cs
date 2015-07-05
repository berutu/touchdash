using UnityEngine;
using System.Collections;

public class Sorcerer : PlayerBase {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region implemented abstract members of PlayerBase
	public override IEnumerator Attack ()
	{
		while (true) {
			attackEffect.SetActive (true);
			yield return new WaitForSeconds (attackingSpeed);
			attackEffect.SetActive (false);
			yield return new WaitForSeconds (intervalTime);
		}
	}

	public override void Damage ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
