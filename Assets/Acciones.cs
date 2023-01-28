using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Acciones : MonoBehaviour
{
	public TextMeshProUGUI posibles, operacion, entrada1, entrada2, resultado;
	public int puntos = 0;
	public GameObject [] botones;
	
	void Pregunta1()
	{
		posibles.text = "1, 8, 5, 3";
		operacion.text = "+";
		resultado.text = "11";
		
		if(entrada1.text == "8" && entrada2.text == "3")
		{
			puntos++;
		}
		else if(entrada1.text == "3" && entrada2.text == "8")
		{
			puntos++;
		}
		botones[0].SetActive(false);
		botones[1].SetActive(true);
		
		//Inicializar Pregunta 2
	}
}
