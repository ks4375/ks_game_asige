using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class distance_script : MonoBehaviour {

	public static int flg;

	public GameObject _player;
	public Camera _camera;
	public Text _text;
	public float _distance = 500.0f;
	private float _distanse_a;
	private float _camera_pos;
	private float time;

	public GameObject _goal;

	// Use this for initialization
	void Start () {
		flg = 0;

	}
	
	// Update is called once per frame
	void Update () {
        if (_player.transform.position.y <= 30.0f) {
			Vector3 goal_pos = new Vector3 (0.0f, 30.0f);
			Vector3 player_pos = new Vector3 (0.0f, _player.transform.position.y);
			float dis = Vector3.Distance (goal_pos, player_pos);
			dis = dis * 6.0f;
			float _dis = Mathf.Round (dis);
			_text.text = _dis.ToString () + "m";
		} else {
			_text.text = "0m";
			time++;
			if (time >= 120) {
				flg = 1;
			}
		}
	}
}
