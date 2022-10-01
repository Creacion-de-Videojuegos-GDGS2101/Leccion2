//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*Clase PlayerController
*author: José Guillermo Balderas Zamora
*
*Clase PlayerController tiene la funcion de dar soporte al movimiento del personaje sobre su mismo espacio x de derecha a izquierda
* y del mismo modo lanzar proyectiles desde el mismo personaje
*
*/
public class PlayerController : MonoBehaviour
{


    //Variable tipo GameObject que sera el proyectil
    public GameObject proyectil;

    
    // Variable tipo float
    float horInput;

    //Variable tipo float con el limite de  movimiento
    float limiteMov = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {   
        // Fragmento de codigo que sirve para movilidad sobre el eje x
        if(transform.position.x > limiteMov){
            transform.position = new Vector3(limiteMov,
            transform.position.y, transform.position.z);
        }
        // Fragmento de codigo que sirve para movilidad sobre el eje x
        if(transform.position.x < -limiteMov){
            transform.position = new Vector3(-limiteMov,
            transform.position.y, transform.position.z);
        }

        // Fragmento de codigo para hacer instancias de objetos de tipo beer (proyectiles)
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(proyectil, transform.position,
            proyectil.transform.rotation);
        }

        // Fragmento de codigo para hacer Movimiento del jugador de manera horizontal
        float horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
