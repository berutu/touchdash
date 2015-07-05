using UnityEngine;
using System.Collections;

public class Fairy : MonsterBase {
	

	#region implemented abstract members of MonsterBase

	public override void Move ()
	{
		//throw new System.NotImplementedException ();
	}

	public override void Attack ()
	{
		throw new System.NotImplementedException ();
	}

	public override IEnumerator Damage ()
	{
		throw new System.NotImplementedException ();
	}
	
	public override void NockBack ()
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
