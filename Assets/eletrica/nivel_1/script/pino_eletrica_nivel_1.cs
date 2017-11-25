using UnityEngine;
using System.Collections;

public class pino_eletrica_nivel_1 : MonoBehaviour {

	public GameObject bancada;
	public GameObject pino;
	public int i;

	public void OnMouseDown(){
		int.TryParse (pino.name, out i);
		bancada.GetComponent<apertou_eletrica_nivel_1>().local [i] = -1;
	}
}
