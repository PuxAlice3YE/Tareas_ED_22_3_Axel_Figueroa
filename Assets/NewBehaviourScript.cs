using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    //Realizado por Axel Figueroa matricula 335002633
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            texto.text = "a estudiar, mucho exito!";
        }
        if(Input.GetKeyDown(KeyCode.B)){
            texto.text = "Hora de pasar un buen rato";
        }
        if(Input.GetKeyDown(KeyCode.C)){
            texto.text = "a ver series!";
        }
        if(Input.GetKeyDown(KeyCode.D)){
            texto.text = "ZZzzzz";
        }
    }
}
