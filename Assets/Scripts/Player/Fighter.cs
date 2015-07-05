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
