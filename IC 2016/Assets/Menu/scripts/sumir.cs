using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sumir : MonoBehaviour {
    public bool trocar=false,acabou=false;
    public GameObject cena,tela;
    // Use this for initialization
    void Update()
    {
        if (trocar == true)
        {
            cena.SetActive(trocar);
        }
        if(trocar == false)
        {
            cena.SetActive(trocar);
        }
        if(acabou == true)
        {
            tela.SetActive(acabou);
        }
	}
	
}
