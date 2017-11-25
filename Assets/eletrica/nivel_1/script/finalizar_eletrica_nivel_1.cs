using UnityEngine;
using System.Collections;

public class finalizar_eletrica_nivel_1 : MonoBehaviour {

	public GameObject bancada,texto;

	public void OnMouseDown(){
		bancada.GetComponent<problema_eletrica_nivel_1> ().finalizar ();
	}
	public void OnMouseOver(){
		texto.SetActive (true);
	}
	public void OnMouseExit(){
		texto.SetActive (false);
	}
}
