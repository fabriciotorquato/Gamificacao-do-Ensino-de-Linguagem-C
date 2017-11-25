using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class problema_eletrica_nivel_1 : MonoBehaviour {

	public string[,] comparacao = new string[4,3];
	public int[] numb = new int[2];
	public Text prova;
	public string resp;
	public int teste1,teste2;
	public GameObject bancada,texto,tela,controle;

	void Start () {
		numb [0] = Random.Range (0, 5);
		numb [1] = Random.Range (numb [0]+1, 10);
		comparacao [0, 0] = "x<";
		comparacao [0, 1] = "x>";
		comparacao [0, 2] = " || ";
		comparacao [1, 0] = "x<=";
		comparacao [1, 1] = "x>=";
		comparacao [1, 2] = " || ";
		comparacao [2, 0] = "x>";
		comparacao [2, 1] = "x<";
		comparacao [2, 2] = " && ";
		comparacao [3, 0] = "x>=";
		comparacao [3, 1] = "x<=";
		comparacao [3, 2] = " && ";
		teste2 = Random.Range (0, 4);
		prova.text = comparacao [teste2, 0] + numb [0] + comparacao[teste2,2] + comparacao [teste2, 1] + numb [1]; 

	}
	public void finalizar(){
		if (bancada.GetComponent<acender_eletrica_nivel_1> ().troca == true && bancada.GetComponent<acender_eletrica_nivel_1> ().igual == true)
			teste2 = 3;
		if (bancada.GetComponent<acender_eletrica_nivel_1> ().troca == true && bancada.GetComponent<acender_eletrica_nivel_1> ().igual == false)
			teste2 = 2;
		if (bancada.GetComponent<acender_eletrica_nivel_1> ().troca == false && bancada.GetComponent<acender_eletrica_nivel_1> ().igual == true)
			teste2 = 1;
		if (bancada.GetComponent<acender_eletrica_nivel_1> ().troca == false && bancada.GetComponent<acender_eletrica_nivel_1> ().igual == false)
			teste2 = 0;
		numb [0] = bancada.GetComponent<apertou_eletrica_nivel_1> ().local [0];
		numb[1] = bancada.GetComponent<apertou_eletrica_nivel_1> ().local [1];

		if (numb[0] > numb[1]) {
			teste1 = numb[0];
			numb[0] = numb[1];
			numb[1] = teste1;
		}

		resp = comparacao [teste2, 0] + numb [0] + comparacao[teste2,2] + comparacao [teste2, 1] + numb [1]; 
		if (resp == prova.text) {
			tela.SetActive (true);
            tela.GetComponent<Sair>().acertou = true;
            controle.GetComponent<fase_ponto>().pontuacao();
        }
        else
        {
            tela.SetActive(true);
            tela.GetComponent<Sair>().acertou = false;
        }
	}
}
