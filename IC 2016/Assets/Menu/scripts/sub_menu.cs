using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sub_menu : MonoBehaviour
{
	public Text resp;

	void Start () {
		resp = GameObject.Find ("resp").GetComponent<Text> ();
	}
	public void nada () {
		resp.text = "";
	}
	public void treinamento_matriz(){
		resp.text = "Exercicio Envolvendo Matriz";
	}
	public void treinamento_string(){
		resp.text = "Exercicio Envolvendo Strings";
	}
	public void treinamento_operacoes(){
		resp.text = "Exercicio Envolvendo Operações Simples";
	}
	public void eletrica_nivel_1(){
		resp.text = "Exercicio Envolvendo Comparações de Variaveis";
	}
	public void producao_nivel_1(){
		resp.text = "Exercicio Envolvendo Funções de Entrada e Saida";
	}
    public void producao_nivel_2()
    {
        resp.text = "Exercicio Envolvendo Comparações entre Variaveis";
    }
    public void mecanica_nivel_1()
    {
        resp.text = "Exercicio Envolvendo Atribuições a Variaveis";
    }
    public void civil_nivel_1()
    {
        resp.text = "Exercicio Envolvendo Possições de Matrizes";
    }
}