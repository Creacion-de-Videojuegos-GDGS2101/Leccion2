//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
*Clase SpawnManager
*author: José Guillermo Balderas Zamora
*
*Clase SpawnManager tiene la funcion de dar soporte a la creación de varios animales para que sean impresos
* en la pantalla de manera aleatoria.
*
*/
public class SpawnManager : MonoBehaviour
{
    // Arreglo tipo GameObject 
    public GameObject[] arrDogs;
    
    // Start is called before the first frame update
    void Start()
    { 
        // Al iniciar empieza la repeticion de los animales
        InvokeRepeating("CreateAnimal", 1.5F, 1.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Funcion para crear animales
    void CreateAnimal()
    {
        // Variable tipo int para crea rango para la creacion de un animal
        int aleatorio = Random.Range(0, 3);

        // Variable tipo int para crea rango para la creacion de un animal
        int valX = Random.Range(-20,20);


        // Se hace la instancia de los animales
        Instantiate(arrDogs[aleatorio], new Vector3(valX, transform.position.y, -10), arrDogs[aleatorio].transform.rotation);


    }
}
