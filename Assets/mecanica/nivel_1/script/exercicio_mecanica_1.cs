using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class exercicio_mecanica_1 : MonoBehaviour {
    public string[] exe = new string[6];
    public string[] responder = new string[2];
    public Text[] alternativa = new Text[5];
    public int numb, x,quest,aux,resultado_real,resultado_mostrado,contador;
    public Text tela,valor,pergunta;
    public GameObject fim,inicio;
    public Animator anim;

    void Start () {
        contador = 0;
        exe[0] = "x++";
        exe[1] = "x+1";
        exe[2] = "x--";
        exe[3] = "x-1";
        exe[4] = "++x";
        exe[5] = "--x";
        responder[0] = "Qual o valor mostrado ao usuário";
        responder[1] = "Qual o valor de X";
        anim = GetComponent<Animator>();
        iniciar();
    }

    public void iniciar() {
            valor.text = "valor de x = ";
            numb = UnityEngine.Random.Range(0, 6);
            tela.text = exe[numb];
            x = UnityEngine.Random.Range(-10, 10);
            valor.text += x.ToString();
            quest = UnityEngine.Random.Range(0, 2);
            pergunta.text = responder[quest];
            opcao();
            acertou();
    }

    public void opcao() {
        aux = x - 2;
        alternativa[0].text = aux.ToString();
        aux = x - 1;
        alternativa[1].text = aux.ToString();
        aux = x;
        alternativa[2].text = aux.ToString();
        aux = x +1;
        alternativa[3].text = aux.ToString();
        aux = x +2;
        alternativa[4].text = aux.ToString();
    }
    public void acertou(){
        if (numb == 0) {
            resultado_mostrado = x;
            resultado_real = x + 1;
        }
        else if (numb == 1){
            resultado_mostrado = x+1;
            resultado_real = x;
        }
        else if (numb == 2)
        {
            resultado_mostrado = x;
            resultado_real = x-1;
        }
        else if (numb == 3)
        {
            resultado_mostrado = x -1;
            resultado_real = x;
        }
        else if (numb == 4)
        {
            resultado_mostrado = x + 1;
            resultado_real = x+1;
        }
        else if (numb == 5)
        {
            resultado_mostrado = x - 1;
            resultado_real = x-1;
        }

    }
}
