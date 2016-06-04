using UnityEngine;
using System.Collections;

public class camera_script : MonoBehaviour {

	public float camera_speed;
	private int grade_;

	// Use this for initialization
	void Start () {
		grade_ = SceneChange.grade;
		switch (grade_) {
		case 0: //OP
			camera_speed = 0.045f;
			return;
		case 1: //G3
			camera_speed = 0.06f;
			return;
		case 2: //G2
			camera_speed = 0.08f;
			return;
		case 3: //G1
			camera_speed = 0.095f;
			return;
		case 4: //海外G1
			camera_speed = 0.2f;
			return;
		default :
			return;	
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= 30) {
			transform.position = new Vector3 (
				0.0f,
				transform.position.y + camera_speed,
				-10.0f
			);
		}
	}
}
