//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

//IMPORTACIONES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
*Clase Colisionador
*author: José Guillermo Balderas Zamora
*
*Clase Colisionador tiene la funcion de ayudar en el momento que el objeto sea arrojado este mismo
*  impacte con el objeto de tipo animal sean destruidos por el proyectil
*
*/

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Funcion que tiene como objetivo destruir elementos.
    void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
    }

    
}
