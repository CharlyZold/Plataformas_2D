﻿using UnityEngine;
using System.Collections;

public class checkpointo : MonoBehaviour {
	private GameControlScript gcs;
	private Animator anim;
	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			gcs.checkpoint (transform.position);
			anim.SetBool ("contacto_player", true);
		}
	}
}
