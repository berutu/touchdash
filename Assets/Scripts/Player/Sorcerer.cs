using UnityEngine;
using System.Collections;

public class Sorcerer : PlayerBase {

	// Use this for initialization
	void Start () {
		attackingSpeed = 0.35f;
		intervalTime = 3.0f;
		StartCoroutine ("Attack");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region implemented abstract members of PlayerBase

	public override void Damage ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
