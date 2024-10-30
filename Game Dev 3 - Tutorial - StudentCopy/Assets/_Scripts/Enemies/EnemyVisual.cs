using UnityEngine;

public class EnemyVisual : MonoBehaviour
{

    SpriteRenderer spriteRenderer;//create empty sprite renderer data
    public EnemyData enemyData; // call enemyData SO

    // Start is called before the first frame update
    void Start()
    {
        //gets the sprite renderer component and casts it to the empty spriteRenderer variable
        spriteRenderer = GetComponent<SpriteRenderer>();
        //now set the sprite
        spriteRenderer.sprite = enemyData.shipSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
