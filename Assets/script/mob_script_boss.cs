﻿using UnityEngine;
using System.Collections;

public class mob_script_boss: MonoBehaviour {

	private float mob_speed;//0.03f

	// Use this for initialization
	void Start () {
        mob_speed = Random.Range(0.04f, 0.07f);
    }

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (
			transform.position.x,
			transform.position.y + mob_speed,
			0.0f
		);

	}
}
