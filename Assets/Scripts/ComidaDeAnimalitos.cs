using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{
    public string codigo;
    public int diasDeEstadia;
    
    // Start is called before the first frame update
    void Start()
    {
       if(codigo == "G" && diasDeEstadia > 3)
        {

        }else if (codigo == "PP" && diasDeEstadia > 3)
        {

        }else if (codigo == "PG" && diasDeEstadia > 3)
        {

        }else
        {
            Debug.Log("El código y/o días de estadía no son válidos");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
