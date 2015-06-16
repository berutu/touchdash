using UnityEngine;
using System.Collections;

public class PlayerParty : MonoBehaviour {

	public int membership;

	// Use this for initialization
	void Start () {
		membership = transform.childCount;
		FormationChange();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Stationary){
				Forward ();
			}
		}
		if (membership != transform.childCount) {
			membership = transform.childCount;
			FormationChange();		
		}

	}

	public void Forward(){
		
	}

	public void FormationChange(){
		float changeTime = 1.0f;
		switch (membership) {
		case 1:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			break;
		case 2:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(0.55f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(-1.15f, -3f, 0f), changeTime);
			break;
		case 3:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(1.4f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-2f, -3f, 0f), changeTime);
			break;
		case 4:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(1.4f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-2f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(3).gameObject, new Vector3(-0.3f, -1.3f, 0f), changeTime);
			break;
		case 5:
			iTween.MoveTo(transform.GetChild(0).gameObject, new Vector3(-0.3f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(1).gameObject, new Vector3(1.4f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(2).gameObject, new Vector3(-2f, -3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(3).gameObject, new Vector3(0.55f, -1.3f, 0f), changeTime);
			iTween.MoveTo(transform.GetChild(4).gameObject, new Vector3(-1.15f, -1.3f, 0f), changeTime);
			break;
		}
	}
}
