using UnityEngine;
using System.Collections;

public class Fairy : MonsterBase {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region implemented abstract members of MonsterBase

	public override void Move ()
	{
		throw new System.NotImplementedException ();
	}

	public override void Attack ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
