using UnityEngine;
using System.Collections;

public class introducao : MonoBehaviour {

	public int numb,i;
	public GameObject[] telas = new GameObject[8];
	public GameObject visualizar,tutorial;
	void Start () {
		i = 0;
		
	}
	public void frente(){
		telas [i].SetActive (false);
		i++;
		if (i < numb)
			telas [i].SetActive (true);
		else {
			visualizar.SetActive (false);
			tutorial.SetActive (true);
		}
	}
	public void tras(){
		telas [i].SetActive (false);
		i--;
		if (i >= 0)
			telas [i].SetActive (true);
		else {
			i = 0;
			telas [i].SetActive (true);
		}
	}
	public void pular(){
		visualizar.SetActive (false);
		tutorial.SetActive (true);
	}
}
