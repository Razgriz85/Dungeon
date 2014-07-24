﻿using System;
using UnityEngine;

/*******************************************
 * Script para el control de las escenas
 * Muestra un boton para salir del juego
 * (No funciona en web)
 *******************************************/
public class EscenaScript : MonoBehaviour {

	public Texture2D keyImage;

	// Esto se hara al arrancar cada escena
	void Start ()
	{
		// Reseteamos el cursor por si venimos de clicar en algo
		// y tenemos otro cursor puesto
		try
		{
			// Cambiamos el cursor
			Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
			// Escondemos el texto del cursor
			GestorTextoCursorScript.cursor.HideText();
		}
		catch (Exception e)
		{
			if (Debug.isDebugBuild)
			{
				Debug.LogException(e);
			}
		}
	}


	void OnGUI()
	{
		// Dimensiones del boton
		const int buttonWidth = 80;
		const int buttonHeight = 50;

		// Dibujamos el boton para salir del juego (en web no funciona)
		if ( GUI.Button( new Rect(Screen.width - 90, 10, buttonWidth, buttonHeight), "Salir") )
		{
			Application.Quit();
		}


		// Indicador de llaves en nuestro poder

		// Dibujamos el boton para volver a la escena anterior
		if (!keyImage) {
			Debug.LogError("Mete una textura para la llave en el Inspector zoquete!");
			return;
		} 
		else
		{
			GUI.DrawTexture(new Rect(Screen.width - 180, 10, 48, 48), keyImage, ScaleMode.ScaleToFit, true, 0);
		}

		GUI.Label(new Rect(Screen.width - 144, 32, 64, 32), "x " + GestorInventarioScript.inventory.GetNumberOfKeys());


	}

}
