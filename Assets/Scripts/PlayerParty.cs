using UnityEngine;
using System.Collections;

public class PlayerParty : MonoBehaviour {

	public int membership;
	public Vector2 offset;
	public float moveSpeed;
	public float recedeSpeed;

	// Use this for initialization
	void Start () {
		membership = transform.childCount;
		FormationChange();
		offset = new Vector2 (0f, 0f);
		moveSpeed = 0.02f;
		recedeSpeed = 0.01f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 || Input.GetMouseButton (0)) {
			Forward ();
		} else if (offset.y >= 0f) {
			offset.y -= recedeSpeed;
		}

		if (membership != transform.childCount) {
			membership = transform.childCount;
			FormationChange();		
		}
		transform.position = new Vector3 (offset.x, offset.y, 0f);
		//transform.localPosition.Set(offset.x, offset.y, offset.z);
	}

	public void Forward(){
		offset.y += moveSpeed;
	}

	public void FormationChange(){
		float changeTime = 1.0f;
		switch (membership) {
		case 1:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			break;
		case 2:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(0.1f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(-0.7f, -3f, 0f), changeTime);
			break;
		case 3:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(0.5f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-1.1f, -3f, 0f), changeTime);
			break;
		case 4:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(0.5f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-1.1f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(3).gameObject, new Vector3(-0.3f, -2.1f, 0f), changeTime);
			break;
		case 5:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(0.5f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-1.1f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(3).gameObject, new Vector3(0.1f, -2.1f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(4).gameObject, new Vector3(-0.7f, -2.1f, 0f), changeTime);
			break;
		}
	}
}
