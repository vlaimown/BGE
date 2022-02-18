//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Image fillBar;
    public float health;

    public void LoseHealth(int value)
    {
        //Do nothing if you are out of health
        if (health <= 0)
            return;
        //Reduce the health
        health -= value;
        //Refresh the UI fillBar
        fillBar.fillAmount = health / 100;
        //Check if your health is zero or less => Dead
        if (health <= 0)
        {
            Debug.Log("Вы отчислены");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            LoseHealth(25);
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
