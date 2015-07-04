using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Fighter : PlayerBase{

	// Use this for initialization
	void Start () {
		attackingSpeed = 1.0f;
		intervalTime = 1.0f;
		StartCoroutine("Attack");
	}

	#region implemented abstract members of PlayerBase


	public override void Damage ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
