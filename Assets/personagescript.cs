using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagescript : MonoBehaviour
{
    public int nivelHambre;
    void TomarAlimento(int valorAlimentario)
    {

    }
        
    private void OnTriggerEnter(Collider other)
        {


            AlimentoScript alimento;
            alimento = other.GetComponent<AlimentoScript>();
            if (alimento)

            {

                TomarAlimento(alimento.valorAlimentario);
                Destroy(other.gameObject);


            }
        }


    }
