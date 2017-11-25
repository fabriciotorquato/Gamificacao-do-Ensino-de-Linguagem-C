using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class compilador : MonoBehaviour {
public static int [,] m1=new int[3,2];
public static int [,] m2=new int[3,2];
public static int [,] m3=new int[3,2];
public string caracter;
    public GameObject pontos;
	public Text cmpm1,cmpm2,cmpm3;
	public Text m1_if,m2_if,m3_if;
int i;
	void Start () {
		m1 [0,0] = 0;
		m1 [1,0] = 0;
		m1 [2,0] = 0;
		m2 [0,0] = 0;
		m2 [1,0] = 0;
		m2 [2,0] = 0;
		m3 [0,0] = 0;
		m3 [1,0] = 0;
		m3 [2,0] = 0;
		m1 [0,1] = -1;
		m1 [1,1] = -1;
		m1 [2,1] = -1;
		m2 [0,1] = -1;
		m2 [1,1] = -1;
		m2 [2,1] = -1;
		m3 [0,1] = -1;
		m3 [1,1] = -1;
		m3 [2,1] = -1;
	}
	public void compiladorm1()
	{
		ifcara ();
		if (m1 [0, 0] == 0 || m1 [1, 0] == 0 || m1 [2, 0] == 0) {
			cmpm1.text = "Erro na Sintaxe";
		}
		else {
			if (m1 [0, 1] == 2 || m1 [0, 1] == 3 || m1 [0, 1] == 4 || m1 [0, 1] == 5) {
				cmpm1.text = "Erro na Sintaxe";	
			} else if (m1 [1, 1] == 6 || m1 [1, 1] == 7 || m1 [1, 1] == 8) {
				cmpm1.text = "Erro na Sintaxe";	
			} else if (m1 [2, 1] == 2 || m1 [2, 1] == 3 || m1 [2, 1] == 4 || m1 [2, 1] == 5) {
				cmpm1.text = "Erro na Sintaxe";	
			} else {
				cmpm1.text = "Sintaxe correta";
				m1_if.text = caracter;
			}
		}
	}
	public void compiladorm2()
	{
		ifcaram2();
		if (m2 [0, 0] == 0 || m2 [1, 0] == 0 || m2 [2, 0] == 0) {
			cmpm2.text = "Erro na Sintaxe";
		}
		else {
			if (m2 [0, 1] == 2 || m2 [0, 1] == 3 || m2 [0, 1] == 4 || m2 [0, 1] == 5) {
				cmpm2.text = "Erro na Sintaxe";	
			} else if (m2 [1, 1] == 6 || m2 [1, 1] == 7 || m2 [1, 1] == 8) {
				cmpm2.text = "Erro na Sintaxe";	
			} else if (m2 [2, 1] == 2 || m2 [2, 1] == 3 || m2 [2, 1] == 4 || m1 [2, 1] == 5) {
				cmpm2.text = "Erro na Sintaxe";	
			} else {
				cmpm2.text = "Sintaxe correta";
				m2_if.text = caracter;
			}
		}
	}
	public void compiladorm3()
	{
		ifcaram3();
		if (m3 [0, 0] == 0 || m3 [1, 0] == 0 || m3 [2, 0] == 0) {
			cmpm3.text = "Erro na Sintaxe";
		}
		else {
			if (m3 [0, 1] == 2 || m3 [0, 1] == 3 || m3 [0, 1] == 4 || m3 [0, 1] == 5) {
				cmpm3.text = "Erro na Sintaxe";	
			} else if (m3 [1, 1] == 6 || m3 [1, 1] == 7 || m3 [1, 1] == 8) {
				cmpm3.text = "Erro na Sintaxe";	
			} else if (m3 [2, 1] == 2 || m3 [2, 1] == 3 || m3 [2, 1] == 4 || m3 [2, 1] == 5) {
				cmpm3.text = "Erro na Sintaxe";	
			} else {
				cmpm3.text = "Sintaxe correta";
				m3_if.text = caracter;
			}
		}
	}
	public void ifcara()
	{
		caracter = "if(";
		for (i = 0; i < 3; i++) {

			switch (m1[i,1]) {
			case 1:
				caracter += "peso ";

				break;
			case 2:
				caracter += "> ";
				break;
			case 3:
				caracter += ">= ";
				break;
			case 4:
				caracter += "< ";
				break;
			case 5:
				caracter += "<= ";
				break;
			case 6:
				caracter += "3 ";
				break;
			case 7:
				caracter += "7 ";
				break;
			case 8:
				caracter += "12 ";
				break;
			default:
				caracter+=" ";
				break;
			}
		}
		caracter += ")";	
	}
	public void ifcaram2()
	{
		caracter = "if(";
		for (i = 0; i < 3; i++) {

			switch (m2[i,1]) {
			case 1:
				caracter += "peso ";

				break;
			case 2:
				caracter += "> ";
				break;
			case 3:
				caracter += ">= ";
				break;
			case 4:
				caracter += "< ";
				break;
			case 5:
				caracter += "<= ";
				break;
			case 6:
				caracter += "3 ";
				break;
			case 7:
				caracter += "7 ";
				break;
			case 8:
				caracter += "12 ";
				break;
			default:
				caracter+=" ";
				break;
			}
		}
		caracter += ")";	
	}
	public void ifcaram3()
	{
		caracter = "if(";
		for (i = 0; i < 3; i++) {

			switch (m3[i,1]) {
			case 1:
				caracter += "peso ";

				break;
			case 2:
				caracter += "> ";
				break;
			case 3:
				caracter += ">= ";
				break;
			case 4:
				caracter += "< ";
				break;
			case 5:
				caracter += "<= ";
				break;
			case 6:
				caracter += "3 ";
				break;
			case 7:
				caracter += "7 ";
				break;
			case 8:
				caracter += "12 ";
				break;
			default:
				caracter+=" ";
				break;
			}
		}
		caracter += ")";	
	}
	public void executar()
	{
		if (instanciar.gatilho == false && test_comp(m1) && test_comp(m2) && test_comp(m3)) {
			instanciar.gatilho = true;
            pontos.GetComponent<fase_ponto>().pontuacao();
        }
	}
	public bool test_comp(int[,]m)
	{
		if (m [0, 0] == 0 || m [1, 0] == 0 || m [2, 0] == 0) {
			return false;
		}
		else {
			if (m [0, 1] == 2 || m [0, 1] == 3 || m [0, 1] == 4 || m [0, 1] == 5) {
				return false;
			} else if (m [1, 1] == 6 || m [1, 1] == 7 || m [1, 1] == 8) {
				return false;
			} else if (m [2, 1] == 2 || m [2, 1] == 3 || m [2, 1] == 4 || m [2, 1] == 5) {
				return false;	
			} else {
				return true;
			}
		}
	}
}
