using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mole : MonoBehaviour
{
    public float despawnTimer;
    public GameObject mole;
    private GameManager gameManager;
    public int scorePoints;

    private void Start()
    {
        gameManager = transform.root.GetComponent<GameManager>();
    }

    public void Hit()
    {
        mole.SetActive(false);
        gameManager.GetPoints(scorePoints);
    }
    public void Spawn()
    {
        mole.SetActive(true);
        StartCoroutine(DespawnTimer());
    }

    public void Despawn()
    {
        mole.SetActive(false);
    }

    public IEnumerator DespawnTimer()
    {
        yield return new WaitForSeconds(despawnTimer);
        Despawn();
    }
}
