using UnityEngine;
using System.Collections;

public class acender_eletrica_nivel_1 : MonoBehaviour {

	public GameObject bancada;
	public GameObject[] luz= new GameObject[10];
	public int um,zero,i;
	public bool troca,igual;
	void Start () {
		troca = false;
		igual = false;
	}
	
	// Update is called once per frame
	void Update () {
		zero = bancada.GetComponent<apertou_eletrica_nivel_1> ().local [0];
		um = bancada.GetComponent<apertou_eletrica_nivel_1> ().local [1];
		if (zero > um) {
			i = zero;
			zero = um;
			um = i;
		}
		for (i = 0; i < 10; i++)
			luz [i].GetComponent<Light> ().intensity = 0;
		if (zero != -1 && um != -1) {
			if (troca == true) {
				if (igual == true) {
					for (i = zero; i <= um; i++)
						luz [i].GetComponent<Light> ().intensity = 2;
				} else {
					for (i = zero + 1; i < um; i++)
						luz [i].GetComponent<Light> ().intensity = 2;
				}
			} else {
				if (igual == true) {
					for (i = 0; i <= zero; i++)
						luz [i].GetComponent<Light> ().intensity = 2;
					for (i = um; i <= 9; i++)
						luz [i].GetComponent<Light> ().intensity = 2;
				} else {
					for (i = 0; i < zero; i++)
						luz [i].GetComponent<Light> ().intensity = 2;
					for (i = um+1; i <= 9; i++)
						luz [i].GetComponent<Light> ().intensity = 2;
				}
			}
			
		}
	}
	public void inverter(){
		if (troca == true)
			troca = false;
		else
			troca=true;
	}
	public void incluir(){
		if (igual == true)
			igual = false;
		else
			igual=true;
	}
}
