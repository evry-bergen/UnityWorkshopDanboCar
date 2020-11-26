using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneControllerTut : MonoBehaviour
{
    public UnityEvent EnemiesDefeated;

    public TextMeshProUGUI enemyText;
    // Start is called before the first frame update
    [SerializeField]
    private int _allEnemiesCount;
    [SerializeField]
    private int _deadEnemiesCount;

    void Start()
    {
        _allEnemiesCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyText.text = "Boxes left: " + _deadEnemiesCount + "/" + _allEnemiesCount;
    }

    public void checkIfAllEnemiesAreDead()
    {
        _deadEnemiesCount++;
        if (_deadEnemiesCount == _allEnemiesCount)
        {
            EnemiesDefeated.Invoke();
        }
        enemyText.text = "Boxes left: " + _deadEnemiesCount + "/" + _allEnemiesCount;
    }

        public void SceneReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

}
