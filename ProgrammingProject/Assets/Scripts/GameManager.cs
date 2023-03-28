using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int dano;
    [SerializeField] private int vida;
    private int level;
    [SerializeField] private int xpAtual;

    // Start is called before the first frame update
    void Start()
    {
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ExecutarPulo();
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            Atacar(dano);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            print("Estou mais forte! ARRRR!!");
            ReceberDano(45);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            AdicionarXP(50, 100);
        }

    }

    private void ExecutarPulo()
    {
        print("Pular");
        print("Anima��o de pulo");
        print("Cair no ch�o");
        print("Anima��o de pouso");
    }

    private void Atacar(int tempDano)
    {
        print("Estou dando dano de " + tempDano + " pontos de vida!");
    }

    private void ReceberDano(int dano)
    {
        vida -= dano;
        if(vida > 0)
        {
            print("Recebi " + dano + " de dano");
        }
        else if(vida <= 0)
        {
            print("Morri, mas passo bem");
        }
    }

    private void AdicionarXP(int xpAdicional, int xpLevelUp)
    {
        if(xpAtual >= 100)
        {
            level++;
            print("Parab�ns! Voc� subiu n�vel! N�vel atual: " + level);
        }
        else
        {
            xpAtual += xpAdicional;
            print("Eu ganhei " + xpAdicional + " de experi�ncia adicional");
        }

    }


}
