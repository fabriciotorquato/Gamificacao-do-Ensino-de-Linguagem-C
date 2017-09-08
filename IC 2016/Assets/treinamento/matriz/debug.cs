using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class debug : MonoBehaviour {
	
	public int inicio, fim, altura, i, j, y, x, cont;
	public int w, h;
	public RectTransform aux;
	public bool Flag;
	public GameObject programa,ativar;
	public GameObject[] botao = new GameObject[9];
	public GameObject[] condicao = new GameObject[3];
	public Text sucesso;
	public string parametro;

	void Start () {
		parametro= "         ";
		sucesso = GameObject.Find ("sucesso").GetComponent<Text> ();
		sucesso.text = "";
	}

	public void copilar(){
		Flag=true;
        for (int i = 0; i < 9; i++)
        {
            if (ativar.GetComponent<transporta_botao>().b_opcao[i] == 0)
                condicao[0] = botao[i];
            if (ativar.GetComponent<transporta_botao>().b_opcao[i] == 1)
                condicao[1] = botao[i];
            if (ativar.GetComponent<transporta_botao>().b_opcao[i] == 2)
                condicao[2] = botao[i];
        }

        if (condicao[0].tag != "variavel" && condicao[0].tag != "valor")
			Flag=false;
		if(condicao[1].tag != "comparacao")
			Flag=false;
		if(condicao[2].tag != "variavel" && condicao[2].tag != "valor")
			Flag=false;
		if (Flag) {
			parametro = " ";
			parametro += condicao [0].GetComponentInChildren<Text> ().text;
			parametro += " ";
			parametro += condicao [1].GetComponentInChildren<Text> ().text;
			parametro += " ";
			parametro += condicao [2].GetComponentInChildren<Text> ().text;
			parametro += " ";
			sucesso.text = "Sintaxe Correta\nMas Condição Errada";
			comp.op1=condicao[0].GetComponent<mover_botao>().cod;
			comp.op2=condicao[1].GetComponent<mover_botao>().cod;
			comp.op3=condicao[2].GetComponent<mover_botao>().cod;
		} else {
			sucesso.text = " Erro na Sintaxe ";
		}
	}
}
