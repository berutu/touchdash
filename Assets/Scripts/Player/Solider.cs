using UnityEngine;
using System.Collections;

public class Solider : PlayerBase {

	// Use this for initialization
	void Start () {
		attackingSpeed = 1.0f;
		intervalTime = 1.5f;
		StartCoroutine("Attack");
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
