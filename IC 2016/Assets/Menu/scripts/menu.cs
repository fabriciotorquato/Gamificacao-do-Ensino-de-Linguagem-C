using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public void voltar (){
		SceneManager.LoadScene ("menu_inicial");
	}
	public void area (){
		SceneManager.LoadScene ("interface_setor");
	}
	public void treinamento (){
		SceneManager.LoadScene ("interface_treinamento1");
	}
	public void treinamento_matriz(){
		SceneManager.LoadScene ("treinamento_matriz");
	}
	public void treinamento_string(){
		SceneManager.LoadScene ("treinamento_string");
	}
	public void treinamento_operacoes(){
		SceneManager.LoadScene ("treinamento_operacao");
	}
	public void eletrica(){
		SceneManager.LoadScene ("eletrica");
	}
	public void eletrica_nivel_1(){
		SceneManager.LoadScene ("eletrica_nivel_1");
	}
	public void producao(){
		SceneManager.LoadScene ("produção");
	}
	public void producao_nivel_1(){
		SceneManager.LoadScene ("produção_nivel_1");
	}
    public void producao_nivel_2()
    {
        SceneManager.LoadScene("produção_nivel_2");
    }
    public void interface_inicial(){
		SceneManager.LoadScene ("interface_mapa1");
	}
    public void interface_treinamento()
    {
        SceneManager.LoadScene("interface_treinamento1");
    }
    public void mecanica_nivel_1()
    {
        SceneManager.LoadScene("mecanica_nivel_1");
    }
    public void civil_nivel_1l()
    {
        SceneManager.LoadScene("civil_nivel_1");
    }
    public void Sair (){
		Application.Quit ();
	}
}
