using UnityEngine;
using System.Collections;

public abstract class MonsterBase : MonoBehaviour {

	protected const float EDGE_LEFT = -3.0f;
	protected const float EDGE_RIGHT = 3.0f;
	protected const float EDGE_BOTTOM = -6.0f;

	protected float moveSpeedX;
	protected float moveSpeedY;

	// Update is called once per frame
	public void Update () {
		Move();
		if (transform.position.y <= EDGE_BOTTOM)
			Destroy (this.gameObject);
	}

	public abstract void Move ();
	public abstract void Attack ();

}
