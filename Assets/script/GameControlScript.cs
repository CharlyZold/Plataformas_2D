using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	private Vector3 punto_inicio;
	public GameObject player;
	public bool esta_vivo = true;
		
	void Start(){
		punto_inicio = player.transform.position;
	}


	public void respawn(){
		player.transform.position = punto_inicio; //posición de pj igualada a variable que hemos creado
	}

	public void checkpoint (Vector3 nuevo_inicio){
		punto_inicio = nuevo_inicio;
	}
}
