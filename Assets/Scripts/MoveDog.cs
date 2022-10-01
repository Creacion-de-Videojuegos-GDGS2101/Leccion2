//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

//Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*Clase MoveDog
*author: José Guillermo Balderas Zamora
*
*Clase MoveDog tiene la funcion de dar soporte al movimiento de los objetos de tipo Perro
*
*/
public class MoveDog : MonoBehaviour
{
    // Variable tipo float que guarda el limite    
    float limite = 25;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

        // validacion para destruir a los objetos de tipo Perro cuando cruce los limites
        if(transform.position.z < -limite){
            Destroy(gameObject);
        }


        // Movimiento de los objetos de tipo Perro
        transform.Translate(Vector3.forward*Time.deltaTime*15);
    }
}
