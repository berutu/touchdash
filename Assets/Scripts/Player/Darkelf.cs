using UnityEngine;
using System.Collections;

public class Darkelf : PlayerBase {

	// Use this for initialization
	void Start () {
	
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
