using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioVariables : MonoBehaviour {

	public string miNombre;
	public string DiaDeLaSemana;
	public string ProfesorActual;
	public int miEdad;
	public int PuestoEnLaLiga;

	// Use this for initialization
	void Start () {
		 
		Debug.Log ("Imagina llamarte " + miNombre + ", tener " + miEdad + " años y venir un " + DiaDeLaSemana + " a clase de " + ProfesorActual + " después de un jueves festivo, únicamente porque eres el " + PuestoEnLaLiga + "º" + " y quieres rascar algunos puntos en la liga... Jajaja");




		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
