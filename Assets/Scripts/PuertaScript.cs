﻿using System;
using UnityEngine;
using System.Collections;


/************************************************
 * Script para las puerta o salidas de una sala 
 * que nos llevan a otra sala al clicar sobre ellos
 ************************************************/
public class PuertaScript : MonoBehaviour {
	
	// Escena a cargar para la vista detalle
	public string sceneToLoad;


	// Cuando se hace clic dentro del Collider
	void OnMouseDown ()
	{
		// Cargamos la escena especificada (si existe)
		if (sceneToLoad.Length != 0)
		{
			try
			{
				Application.LoadLevel(sceneToLoad);
			}
			catch (Exception e)
			{
				if (Debug.isDebugBuild)
				{
					Debug.LogException(e,this);
				}
			}
		}
		else
		{
			if (Debug.isDebugBuild)
			{
				Debug.Log("<color=blue>No has indicado la escena a cargar!</color>");
			}
		}
	}


	// Establecemos un Gizmo personalizado para estos objetos interactivos
	void OnDrawGizmos() {
		Gizmos.DrawIcon(transform.position, "SalidaGizmo.png");
	}

}
