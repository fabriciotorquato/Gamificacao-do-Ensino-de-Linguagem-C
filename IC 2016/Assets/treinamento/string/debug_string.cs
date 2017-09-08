using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class debug_string : MonoBehaviour {

	public int inicio, fim, altura, i, j, y, x, cont;
	public int w, h;
	public RectTransform aux;
	public bool Flag;
	public GameObject programa;
	public GameObject[] botao = new GameObject[9];
	public GameObject[] condicao = new GameObject[5];
	public Text sucesso;
	public string [] parametro = new string[2];

	void Start () {
		parametro[0]= "         ";
		parametro[1]= "         ";
		sucesso = GameObject.Find ("sucesso").GetComponent<Text> ();
		sucesso.text = "";
		altura = (int)programa.transform.position.y;
		w = (int)aux.rect.width;
		h = (int)aux.rect.height;
	}

	public void copilar(){
		for (i = 0; i < 5; i++) {
			for (j = 0; j < 9; j++) {
				cont = GameObject.Find ("botoes").GetComponent<transporta_botao_string> ().b_opcao [j];
				if (cont == i)
					condicao [i] = botao [j];
			}
		}
		Flag=true;
		if(condicao[0].tag != "variavel" && condicao[0].tag != "valor")
			Flag=false;
		if(condicao[1].tag != "comparacao")
			Flag=false;
		if(condicao[2].tag != "variavel" && condicao[2].tag != "valor")
			Flag=false;
		if(condicao[3].tag != "operacao")
			Flag=false;
		if(condicao[4].tag != "variavel" && condicao[2].tag != "valor")
			Flag=false;
		if (Flag) {
			parametro[0] = condicao [0].GetComponentInChildren<Text> ().text;
			parametro[0] += condicao [1].GetComponentInChildren<Text> ().text;
			parametro[0] += condicao [2].GetComponentInChildren<Text> ().text;
			parametro[1] = condicao [3].GetComponentInChildren<Text> ().text;
			parametro[1] += condicao [4].GetComponentInChildren<Text> ().text;
			sucesso.text = "Sintaxe Correta\nMas Condição Errada";
			//comp.op1=condicao[0].GetComponent<mover_botao>().cod;
			//comp.op2=condicao[1].GetComponent<mover_botao>().cod;
			//comp.op3=condicao[2].GetComponent<mover_botao>().cod;
			//comp.op4=condicao[3].GetComponent<mover_botao>().cod;
			//comp.op5=condicao[4].GetComponent<mover_botao>().cod;
		} else {
			sucesso.text = " Erro na Sintaxe ";
		}
	}
}
