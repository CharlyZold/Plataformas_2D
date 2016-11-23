using UnityEngine;
using System.Collections;

public class generador_monedas : MonoBehaviour {
	public GameObject[] Monedas;
	public Transform pos_salida;
	private GameObject moneda_nueva;
	//private int numero_monedas=0;
	public Animator anim;
	private bool collision = false;
	private int ani=0;

	void start(){
		pos_salida = transform.Find ("posicion_salida").transform;	
	}

	//void OnCollisionEnter2D(Collision2D col){
	//	if (col.gameObject.tag == "Player" && moneda_nueva == null) {
	//		numero_monedas = Random.Range (0, Monedas.Length);
	//		moneda_nueva = (GameObject)Instantiate (Monedas[0], pos_salida.position, transform.rotation);
	//		anim.SetBool ("collision", true);
	//	}
	//}


	void OnTriggerEnter2D(Collider2D objeto){
		
		if (objeto.tag == "Player" && moneda_nueva == null && ani <= 2) {
			moneda_nueva = (GameObject)Instantiate (Monedas[Random.Range (0, Monedas.Length)], pos_salida.position, transform.rotation);
			//numero_monedas = Random.Range (0, Monedas.Length);
			anim.SetBool ("collision", true);
			ani = ani + 1;
		}
		if (objeto.tag == "Player" && moneda_nueva == null && ani == 3) {
			anim.SetBool ("collision", true);
		}
	}
	void OnTriggerExit2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			anim.SetBool ("collision", false);
		}
		if (objeto.tag == "Player" && moneda_nueva == null && ani == 3) {
			anim.SetBool ("collision", false);
		}
	}
}