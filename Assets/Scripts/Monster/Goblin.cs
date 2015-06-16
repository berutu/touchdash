using UnityEngine;
using System.Collections;

public class Goblin : MonsterBase {

	// Use this for initialization
	void Start () {
		moveSpeedX = 0.0f;
		moveSpeedY = 0.01f;
	}


	#region implemented abstract members of MonsterBase

	public override void Move ()
	{
		transform.Translate(new Vector3(moveSpeedX, -moveSpeedY, 0));
	}

	public override void Attack ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
