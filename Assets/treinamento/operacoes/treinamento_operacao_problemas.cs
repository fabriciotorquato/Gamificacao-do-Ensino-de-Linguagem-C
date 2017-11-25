using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class treinamento_operacao_problemas : MonoBehaviour {
	
	public string[] exercicio = new string[3];

	public int[,] prova1 = new int[3,4]{{4,1,3,2},{4,1,3,5},{4,1,3,6}};
	public int[,] prova2 = new int[3,4]{{4,3,1,2},{4,3,1,5},{4,3,1,6}};

	public int[,] teste = new int[2,4];
	public Text pergunta;

	public static int i,j;

	void Start () {
		exercicio[0] = "Problema: Elabore um programa que some dois números ";
		exercicio[1] = "Problema: Elabore um programa que multiplique dois números ";
		exercicio[2] = "Problema: Elabore um programa que subtraia dois números ";
		i = Random.Range (0, 3);
		pergunta.text = exercicio [i];
		for(j=0;j<4;j++){
			teste [0,j] = prova1 [i,j];
			teste [1,j] = prova2 [i,j];
		}
	}
}
