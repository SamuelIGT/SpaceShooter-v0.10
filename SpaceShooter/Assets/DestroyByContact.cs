using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    private void OnTriggerEnter(Collider other)
    {
        //Ignora caso a o objeto colidido seja o Boundary (limites do jogo).
        if (other.tag == "Boundary"){
            return;
        }
        //Instancia a animação de tiro quando os asteróids são atingidos.
        Instantiate(explosion, transform.position, transform.rotation);

        //Caso o Player colida com o asteróide será instanciado uma animação de explosão especial para ele. 
        if(other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        //Destrói o objeto colidido.
        Destroy(other.gameObject);

        //Destrói o asteróide.
        Destroy(gameObject);
    }
}
