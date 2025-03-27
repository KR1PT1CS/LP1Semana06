using System;
 
 namespace MyGame
 {
     public class Enemy
     {
         private string name;
         private float health;
         private float shield;
 
         public Enemy(string name)
         {
             this.name = name;
             SetName(name);
             health = 100;
             shield = 0;
         }
 
         public string GetName()
         {
             return name;
         }
 
         public float GetHealth()
         {
             return health;
         }
 
         public float GetShield()
         {
             return shield;
         }
 
         public void SetName(string newName)
         {
             name = newName.Substring(0, Math.Min(8, newName.Length));
         }
 
         public void TakeDamage(float damage)
         {
             shield -= damage;
         public void TakeDamage(float damage)
         }
     }
 }
 
 