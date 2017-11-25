using UnityEngine;
using System.Collections;

public class instanciar : MonoBehaviour {
	public GameObject atual, menu;
	public GameObject[] pes_caxa=new GameObject[4];
	bool linha;
	int ob,contador,x1,x2,op;
	public static bool gatilho;
	void Start () {
		gatilho = false;
		linha = true;
		ob = 0;
	}

	void Update () {
		if (gatilho == true) {
			if (ob == 0 && linha == true) {
				linha = false;
				GameObject instance = (GameObject)Instantiate (pes_caxa [ob], transform.position, transform.rotation);
				StartCoroutine("tempo");
				ob++;
			} else if (ob < 4 && linha == true) {
				linha = false;
				GameObject instance = (GameObject)Instantiate (pes_caxa [ob], transform.position, transform.rotation);
				ob++;
			} 
			if (contador>=6) {
				Debug.Log ("2");
				StopCoroutine ("tempo");
				linha = true;
				gatilho = false;
				ob = 0;
				contador = 0;
				if (teste (6, compilador.m1) && teste (7, compilador.m2) && teste (8, compilador.m3)) {
					atual.SetActive (false);
					menu.SetActive (true);
				}
			}
	}
	}
	public IEnumerator tempo()
	{
		while(true)
		{
			yield return new WaitForSeconds(2);
			linha = true;
			contador++;
		}
	}
	public bool teste(int cod,int[,]m)
	{
		if ((m [0, 1] == 1 && m [1, 1] == 5 && m [2, 1] == cod) || (m [0, 1] == cod && m [1, 1] == 3 && m [2, 1] == 1)) {
			return true;
		} else
			return false;
	}
}
