using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tradutor_C_string : MonoBehaviour {


	public GameObject copilador;
	public Text pergunta;
	public Text[,] numero = new Text[3,3];
	public string[,] prova = new string[2,2];
	public string encotrar,facens;
	public string[] condicao = new string[2];
	public string[] teste = new string[2];
	public string[,] exercicio = new string[2,2];
	public string inverso;
	public static int[,] numb = new int[3,3];
	public Text sucesso;
    public GameObject vitoria;
    public GameObject ponto;
    public GameObject linha;
    public static int i,j;

	void Start () {
		exercicio[0,0]="str[i]!='\\0'";
		exercicio[0,1]="-=32";
		prova [0,0] = "Problema: Elabore um programa que passe a string para maiucuslo";
		prova [0,1] = "str[i]>='a' && str[i]<='z'";
		exercicio[1,0]="str[i]!='\\0'";
		exercicio[1,1]="+=32";
		prova [1,0] = "Problema: Elabore um programa que passe a string para minusculo";
		prova [1,1] = "str[i]>='A' && str[i]<='Z'";

		i = Random.Range (0, 2);
		teste[0] = exercicio [i,0];
		teste[1] = exercicio [i,1];

		pergunta = GameObject.Find ("Pergunta").GetComponent<Text> ();
		pergunta.text = prova [i,0];

		facens="FaCeNs";

		copilar ();
	}


	void Update () {

	}
	public void copilar(){
		condicao[0] = copilador.GetComponent<debug_string> ().parametro[0];
		condicao[1] = copilador.GetComponent<debug_string> ().parametro[1];
        linha.GetComponent<comp_string>().contador_linha[6].GetComponent<Text>().text = "6\t\t<color=#0000ffff>while</color>(" + condicao[0]+"){";
        linha.GetComponent<comp_string>().contador_linha[7].GetComponent<Text>().text = "7\t\t\t<color=#0000ffff>if</color>(" + prova[i, 1]+")";
        linha.GetComponent<comp_string>().contador_linha[8].GetComponent<Text>().text = "8\t\t\t\ttstr[i]" + condicao[1];
		inverso = revers(teste[0]);
		if ((condicao[0] == teste[0] && condicao[1] == teste[1]) || (condicao[0] == inverso && condicao[1] == teste[1])) {
            vitoria.GetComponent<Sair>().acertou = true;
            ponto.GetComponent<fase_ponto>().pontuacao();
            sucesso = GameObject.Find ("sucesso").GetComponent<Text> ();
			sucesso.text = "Sintaxe Correta";
			comp_string.gat = 1;
		}
	}
	public string revers(string input){
		char[] array = input.ToCharArray ();
		System.Array.Reverse (array);
		return new string (array);
	}
}
