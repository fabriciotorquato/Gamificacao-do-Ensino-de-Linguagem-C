using UnityEngine;
using System.Collections;

public class plug_eletrica_nivel_1 : MonoBehaviour {

	public GameObject bancada;
	public GameObject plug;

	public void OnMouseDown(){
		if (bancada.GetComponent<apertou_eletrica_nivel_1>().local [0] == -1) {
			int.TryParse(plug.name,out bancada.GetComponent<apertou_eletrica_nivel_1>().local [0]);


		} else if(bancada.GetComponent<apertou_eletrica_nivel_1>().local[1]==-1){
			int.TryParse(plug.name,out bancada.GetComponent<apertou_eletrica_nivel_1>().local [1]);

		}	
	}
}
