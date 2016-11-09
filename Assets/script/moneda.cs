using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("Alguien me ha tocado!");
		Destroy (gameObject);
	}
}
