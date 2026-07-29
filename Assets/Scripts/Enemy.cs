using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoints = 3;
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    private bool isDestroyed = false;

    private void Start()
    {
        scoreboard = FindAnyObjectByType<Scoreboard>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {

        if (isDestroyed)
        {
            return;
        }

        hitPoints--;

        if (hitPoints <= 0)
        {
            isDestroyed = true;
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);            
        }       
    }        
    
}
