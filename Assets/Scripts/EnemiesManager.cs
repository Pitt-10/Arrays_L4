using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public Enemy[] enemies;
    public int defaultDamagePointsValue = 5;
    public int counter;

    private void Start () {
        enemies = FindObjectsOfType<Enemy>();
        counter = enemies.Length - 1;
        SetDamagePoints(defaultDamagePointsValue);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (counter >= 0) {
                enemies[counter].gameObject.SetActive(false);
                counter--;
            } else {
                Debug.Log("No hay más enemigos");
            }
        }
    }

    private void SetDamagePoints(int value) {
        for (int i = 0; i < enemies.Length; i++) {
            enemies[i].damagePoints = value;
        }
    }

    private void DeactivateFirstElement(Enemy[] array) {
        array[0].gameObject.SetActive(false);
    }
}
