﻿using UnityEngine;
using UnityEditor;
namespace Enemy.Model
{
    public class ModelEnemy
    {
        public ScriptableEnemy enemyObject;
        int currentHealth;
        public ModelEnemy(ScriptableEnemy enemyTemp)
        {
            enemyObject = enemyTemp;
            currentHealth = enemyObject.maxHealth;
        }
        public bool freez = false;
        
        public Vector3 GetRandomSpawnPoint()
        {
            return new Vector3(Random.Range(-40,41), 5, Random.Range(-40,41));
        }
        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            
        }
        public bool IsAlive()
        {
            return currentHealth > 0;  
        }
        public int GetScore()
        {
            return enemyObject.score;
        }
    }
}