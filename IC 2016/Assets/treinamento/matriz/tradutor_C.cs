using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tradutor_C : MonoBehaviour {

	public GameObject copilador;
	public Text codigo,pergunta;
	public Text[,] numero = new Text[3,3];
	public string[] prova = new string[4];
	public string condicao,encotrar,teste,tabela;
	public string[] exercicio = new string[4];
	public string inverso;
	public int[,] numb = new int[3,3];
	public Text sucesso;
    public GameObject linha;
    public GameObject vitoria,ponto;
	int i,j;

	void Start () {
		exercicio[0]=" i == j ";
		prova [0] = "Problema: Elabore um programa que faça a soma da diagonal principal";
		exercicio[1]=" i == 0 ";
		prova [1] = "Problema: Elabore um programa que faça a soma da primeira linha";
		exercicio[2]=" i == 1 ";
		prova [2] = "Problema: Elabore um programa que faça a soma da segunda linha";
		exercicio[3]=" i == 2 ";
		prova [3] = "Problema: Elabore um programa que faça a soma da terceira linha";

		i = Random.Range (0, 4);
		teste = exercicio [i];

		pergunta = GameObject.Find ("Pergunta").GetComponent<Text> ();
		pergunta.text = prova [i];

		for (i = 0; i < 3; i++)
			for (j = 0; j < 3; j++) {
				numb [i, j] = Random.Range (0, 20);
				encotrar = i.ToString();
				encotrar+= j.ToString();
				numero [i, j] = GameObject.Find (encotrar).GetComponentInChildren<Text> ();
				numero [i, j].text = numb [i, j].ToString (); 
				tabela += "<color=#0000ffff>"+numb [i, j].ToString ()+"</color>"; 
				if(i==2 && j==2)
					tabela +=" ";
				else if(j==2)
					tabela +="},{";
				else
					tabela += " ,";
			}
        linha.GetComponent<comp>().contador_linha[5].GetComponent<Text>().text += tabela+"}}";
    }
	

	void Update () {
		
	}
	public void copilar(){
        condicao = copilador.GetComponent<debug>().parametro;
        linha.GetComponent<comp>().contador_linha[8].GetComponent<Text>().text = "8\t\t\t\t\tif( "+condicao+"){";

		inverso = revers(teste);
		if (condicao == teste || condicao == inverso) {
            vitoria.GetComponent<Sair>().acertou = true;
            ponto.GetComponent<fase_ponto>().pontuacao();
            sucesso = GameObject.Find ("sucesso").GetComponent<Text> ();
			sucesso.text = "Sintaxe Correta";
			comp.gat = 1;
		}
	}
	public string revers(string input){
		char[] array = input.ToCharArray ();
		System.Array.Reverse (array);
		return new string (array);
	}
}