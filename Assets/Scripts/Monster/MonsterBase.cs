using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public abstract class MonsterBase : MonoBehaviour {

	protected const float EDGE_LEFT = -3.0f;
	protected const float EDGE_RIGHT = 3.0f;
	protected const float EDGE_BOTTOM = -6.0f;
	protected const float NOCKBACKTIME = 0.5f;
	protected const float NOCKBACKDISTANCE = 1.0f;

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
	public abstract void NockBack();

	public virtual IEnumerator Damage(){
		NockBack();
		for (int i = 0; i < 6; i++) {
			if(i % 2 == 0)
				GetComponent<SpriteRenderer> ().color = new Color(1, 0, 0, 1);
			else
				GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
			yield return new WaitForSeconds(0.05f);
		}

		Destroy (this.gameObject);
	}

}
