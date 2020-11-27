using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneControllerTut : MonoBehaviour
{

    public UnityEvent EnemyDefeated;

    public TextMeshProUGUI enemyText;

    public int _allEnemiesCount;

    public int _deadEnemiesCount;

    //At start of the scene, we should find out how many enemeies we have, and set the initial enemy UI text
    void Start()
    {

    }

    //Adds to the dead enemy count, also checks if dead enemies count is equal to the total amount of enemies, it should invoke an event that indicates that all enemies are dead
    //Lastly, each and every time this method is fired, it should update the UI text
    public void checkIfAllEnemiesAreDead()
    {

    }

    //A method that reloads the currently loaded scene
    public void SceneReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

}
