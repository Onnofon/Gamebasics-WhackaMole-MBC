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

    //If you hit the mole it leaves and the gamemanager updates the points.
    public void Hit()
    {
        mole.SetActive(false);
        gameManager.GetPoints(scorePoints);
    }  

    //Mole appears
    public void Spawn()
    {
        mole.SetActive(true);
        StartCoroutine(DespawnTimer());
    }

    //Mole leaves
    public void Despawn()
    {
        mole.SetActive(false);
    }

    //Timer for how long the mole can stay
    public IEnumerator DespawnTimer()
    {
        yield return new WaitForSeconds(despawnTimer);
        Despawn();
    }
}
