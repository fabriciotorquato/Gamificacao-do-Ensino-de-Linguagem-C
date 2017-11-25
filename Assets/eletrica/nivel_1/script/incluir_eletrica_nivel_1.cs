using UnityEngine;
using System.Collections;

public class incluir_eletrica_nivel_1 : MonoBehaviour {

	public GameObject bancada;
	public GameObject texto;

	public void OnMouseDown(){
		if (bancada.GetComponent<acender_eletrica_nivel_1>().igual == true)
			bancada.GetComponent<acender_eletrica_nivel_1>().igual = false;
		else
			bancada.GetComponent<acender_eletrica_nivel_1>().igual=true;
	}

	public void OnMouseOver(){
		texto.SetActive (true);
	}
	public void OnMouseExit(){
		texto.SetActive (false);
	}
}
