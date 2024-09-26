using UnityEngine;
//I removed the other two libraries as they were not in use, so it was wasted space/memory

[CreateAssetMenu(fileName = "EnemyData", menuName = "scriptableObjects/EnemyData")]
//this creates an asset menu with a file name of 'EnemyData' and the menu name is 'EnemyData'
public class EnemyData : ScriptableObject
{
    //all varaibles/data types
    public Sprite shipSprite;
    public float shipSpeed;
    public int shipHP;
   
}
