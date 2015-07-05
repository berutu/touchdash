using UnityEngine;
using System.Collections;

public class Fairy : MonsterBase {

	void Start () {
		moveSpeedX = 0.0f;
		moveSpeedY = 0.0f;
	}

	#region implemented abstract members of MonsterBase

	public override void Move ()
	{
		//throw new System.NotImplementedException ();
	}

	public override void Attack ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
