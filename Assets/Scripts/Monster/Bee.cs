using UnityEngine;
using System.Collections;

public class Bee : MonsterBase {

	// Use this for initialization
	void Start () {
		moveSpeedX = 0.02f;
		moveSpeedY = 0.01f;
	}

	#region implemented abstract members of MonsterBase

	public override void Move ()
	{
		if(transform.position.x >= EDGE_RIGHT || transform.position.x <= EDGE_LEFT)
			moveSpeedX *= -1;
		transform.Translate(new Vector3(moveSpeedX, -moveSpeedY, 0));
	}

	public override void Attack ()
	{
		throw new System.NotImplementedException ();
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			NockBack ();
		}
	}

	#endregion
}
