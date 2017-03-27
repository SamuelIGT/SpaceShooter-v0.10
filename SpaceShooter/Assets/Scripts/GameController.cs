using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //Variavel publica que receberá o Game Object 'Asteroid' através da janela 'Inspector'
    public GameObject hazard;

    //Variavel puvlic que receberá os valores dos Spawns para os eixos X, Y e Z.
    public Vector3 spawnValues;

    void Start () {
        SpawnWaves();
	}

    //Função para Spawnar os hazards
	void SpawnWaves(){
        //Seta a posição dos Spawns.
        //A Função 'Random.Range()' retorna uma valor float aleatório que esteja entre os valores passados por parâmetro.
        Vector3 spawnPosition = new Vector3 (Random.Range(spawnValues.x, -spawnValues.x), spawnValues.y, spawnValues.z);
        
        //Um Quaternion serve pra representar rotações.
        //O atributo Quaternion.identity retorna uma rotação nula.
        Quaternion spawnRotation = Quaternion.identity;

        //Instancia os harzads.
        Instantiate(hazard, spawnPosition, spawnRotation);
    }
}
