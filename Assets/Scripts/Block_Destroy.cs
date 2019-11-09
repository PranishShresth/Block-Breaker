using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Destroy : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;
    GameMaster level;
    [SerializeField] GameObject particle;
    private int MaxHits = 3;
    private int TimesHits = 1;
    [SerializeField] Sprite[] DamageLevels;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TimesHits++;
        BlockDestroyEffects();
       
        if (TimesHits >= MaxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            DamageLevelSprites();
        }

    }

    private void DamageLevelSprites()
    {
        int spriteIndex = TimesHits - 1;
        GetComponent<SpriteRenderer>().sprite = DamageLevels[spriteIndex];
    }

    private void BlockDestroyEffects()
    {
        FindObjectOfType<ScoreManager>().AddtoScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        level.BlockDestroyed();
        ParticleEffect();
    }

    private void ParticleEffect()
    {

        GameObject sparkles = Instantiate(particle, transform.position, transform.rotation);
        Destroy(sparkles, 0.5f);
    }
    void Start()
    {
        level = FindObjectOfType<GameMaster>();
        level.CounttheBlocks();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
