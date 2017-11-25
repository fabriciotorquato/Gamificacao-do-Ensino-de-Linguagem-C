using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class correto_mecanica_nivel_1 : MonoBehaviour {
    public GameObject obj;
    int resp,aux,cont;
    public string valor,passou;
    public GameObject fim,controle,crt;

    
    public void clicou(Text numero) {    
        passou = numero.text;
        fim.GetComponent<Sair>().acertou = true;
        aux = obj.GetComponent<exercicio_mecanica_1>().quest;
        if (aux == 0){
            resp=obj.GetComponent<exercicio_mecanica_1>().resultado_mostrado;
            valor = resp.ToString();
            if (valor == numero.text) {
                obj.GetComponent<exercicio_mecanica_1>().contador++;
                cont = obj.GetComponent<exercicio_mecanica_1>().contador;
                obj.GetComponent<exercicio_mecanica_1>().anim.SetInteger("contador", cont);
                obj.GetComponent<exercicio_mecanica_1>().iniciar();
            }
            else if(valor != numero.text) {
                fim.SetActive(true);
                fim.GetComponent<Sair>().acertou = false;
            }
        }
        else {
            resp = obj.GetComponent<exercicio_mecanica_1>().resultado_real;
            valor = resp.ToString();
            if (valor == numero.text)
            {
                obj.GetComponent<exercicio_mecanica_1>().contador++;
                cont = obj.GetComponent<exercicio_mecanica_1>().contador;
                if (cont == 4)
                    crt.GetComponent<fase_ponto>().pontuacao();

                obj.GetComponent<exercicio_mecanica_1>().anim.SetInteger("contador", cont);
                obj.GetComponent<exercicio_mecanica_1>().iniciar();

            }
            else if (valor != numero.text)
            {
                fim.SetActive(true);
                fim.GetComponent<Sair>().acertou = false;
            }
        }
    }
}
