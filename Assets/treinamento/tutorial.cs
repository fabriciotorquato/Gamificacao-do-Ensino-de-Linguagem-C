using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tutorial : MonoBehaviour {

    public int numb, i;
    public GameObject[] telas = new GameObject[5];
    public GameObject[] local = new GameObject[5];
    public GameObject visualizar, seta;

    void Start()
    {
        i = 0;
        seta.transform.position = local[0].transform.position;
    }
    public void frente()
    {
        telas[i].SetActive(false);
        i++;
        if (i < numb)
        {
            telas[i].SetActive(true);
            seta.transform.position = local[i].transform.position;
        }
        else
        {
            visualizar.SetActive(false);
        }
    }
    public void tras()
    {
        telas[i].SetActive(false);
        i--;
        if (i >= 0)
        {
            telas[i].SetActive(true);
            seta.transform.position = local[i].transform.position;
        }
        else
        {
            i = 0;
            telas[i].SetActive(true);
            seta.transform.position = local[i].transform.position;
        }
    }
    public void pular()
    {
        visualizar.SetActive(false);
    }
}
