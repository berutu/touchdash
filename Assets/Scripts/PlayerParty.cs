using UnityEngine;
using System.Collections;

public class PlayerParty : MonoBehaviour {

	public const int MAXSTAMINA = 1000;
	public const float FORWARDSPEED = 0.02f;
	public const float BACKSPEED = 0.01f;
	public const float SIDESPEED = 0.02f;
	public const float CHANGETIME = 0.01f;
	public const int RECEDESTAMINA = 3;
	public const float AXISTHRESHOLD = 0.3f;


	public int membership;
	public Vector2 offset;
	public int stamina;
	public float axisValue;

	// Use this for initialization
	void Start () {
		membership = transform.childCount;
		FormationChange();
		offset = new Vector2 (0f, 0f);
		stamina = MAXSTAMINA;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 0 || Input.GetMouseButton (0)) && stamina >= 0) {
			Forward ();
		} else if (offset.y >= 0f) {
			Back ();
		}

		if (Input.GetAxis ("Horizontal") >= AXISTHRESHOLD) {
			Right ();
		} else if (Input.GetAxis ("Horizontal") <= -AXISTHRESHOLD) {
			Left ();
		}

		if (membership != transform.childCount) {
			membership = transform.childCount;
			FormationChange();		
		}
		transform.position = new Vector3 (offset.x, offset.y, 0f);
	}

	public void Forward(){
		offset.y += FORWARDSPEED;
		stamina -= RECEDESTAMINA;
	}

	public void Back(){
		offset.y -= BACKSPEED;
		if(stamina <= MAXSTAMINA)
			stamina++;
	}

	public void Left(){
		offset.x -= SIDESPEED;
	}

	public void Right(){
		offset.x += SIDESPEED;
	}

	public void FormationChange(){
		switch (membership) {
		case 1:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), CHANGETIME);
			break;
		case 2:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(0.1f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(-0.7f, -3f, 0f), CHANGETIME);
			break;
		case 3:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(0.5f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-1.1f, -3f, 0f), CHANGETIME);
			break;
		case 4:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(0.5f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-1.1f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(3).gameObject, new Vector3(-0.3f, -2.1f, 0f), CHANGETIME);
			break;
		case 5:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(0.5f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-1.1f, -3f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(3).gameObject, new Vector3(0.1f, -2.1f, 0f), CHANGETIME);
			iTween.MoveTo(transform.GetChild(4).gameObject, new Vector3(-0.7f, -2.1f, 0f), CHANGETIME);
			break;
		}
	}
}
