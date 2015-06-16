using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {

	public const int GOBLIN = 1;
	public const int GOBLIN_RARE = 2;
	public const int BEE = 3;
	public const int FAIRY = 4;

	public const float EDGE_LEFT = -3.0f;
	public const float EDGE_RIGHT = 3.0f;
	public const float EDGE_BOTTOM = -6.0f;

	public int tribe;
	public float moveSpeedX;
	public float moveSpeedY;

	// Use this for initialization
	void Start () {
		switch (tribe) {
		case GOBLIN:
			moveSpeedX = 0.0f;
			moveSpeedY = 0.01f;
			break;
		case GOBLIN_RARE:
			moveSpeedX = 0.0f;
			moveSpeedY = 0.02f;
			break;
		case BEE:
			moveSpeedX = 0.02f;
			moveSpeedY = 0.01f;
			break;
		case FAIRY:
			break;  
		}
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		if (transform.position.y <= EDGE_BOTTOM)
			Destroy (this.gameObject);
	}

	void Move(){
		switch (tribe) {
		case GOBLIN:
			transform.Translate(new Vector3(moveSpeedX, -moveSpeedY, 0));
			break;
		case GOBLIN_RARE:
			transform.Translate(new Vector3(moveSpeedX, -moveSpeedY, 0));
			break;
		case BEE:
			if(transform.position.x >= EDGE_RIGHT || transform.position.x <= EDGE_LEFT)
				moveSpeedX *= -1;
			transform.Translate(new Vector3(moveSpeedX, -moveSpeedY, 0));
			break;
		case FAIRY:
			break;
		}
	}
}
