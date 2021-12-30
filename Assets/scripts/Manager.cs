using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject coin;
    public float seconds = 1f;
    public int qtdBox = 0;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnCoin());
    }

  

    private IEnumerator SpawnCoin()
    {
        var eixoX = Random.Range(-6, 6);
        var eixoZ = Random.Range(-4, 4);
        var secondsCoin = Random.Range(3, 10);

        var obj = Instantiate(coin, new Vector3(eixoX, 1.5f, eixoZ), Quaternion.Euler(-89.98f,0,0));

        yield return new WaitForSeconds(secondsCoin);
        yield return SpawnCoin();
    }

    private IEnumerator SpawnEnemy()
    {
        
        qtdBox = Random.Range(1, 7);

        for(int i=1; i < qtdBox; i++)
        {
            var eixoX = Random.Range(-6, 6);
            var eixoZ = Random.Range(-4, 4);
            var drag = Random.Range(-0.7f, 2.5f);
        
            var obj = Instantiate(enemy, new Vector3(eixoX, 15, eixoZ), Quaternion.Euler(85.953f, -230.432f, -258.246f));
            obj.GetComponent<Rigidbody>().drag = drag;
        }

        yield return new WaitForSeconds(seconds);
        yield return SpawnEnemy();
    }
}
