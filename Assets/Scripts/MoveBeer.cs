
//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*Clase MoveBeer
*author: José Guillermo Balderas Zamora
*
*Clase MoveBeer tiene la funcion de dar soporte al movimiento de los objetos proyectiles (tipo beer)
*
*/

public class MoveBeer : MonoBehaviour
{
    //Variable tipo float que almacena la distancia
    public float distancia = 18;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        // Validacion que destruye los objetos de tipo beer
        //En caso que la posicion z sea mayor a la distancia (18) se ejecutara la destrucción
        if(transform.position.z > distancia) {
            Destroy(gameObject);
        }  

        //Movimiento de los objetos tipo beer 
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
