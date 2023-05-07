using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public List<Sprite> spriteCollection;
    private int current = 0;
    public bool switchend = false;

    // public void listSprites(SpriteArray spArray)
    // {
    //     foreach (Sprite sprite in spArray.sprites)
    //     {
    //         spriteCollection.Add(sprite);
    //     }

    //     spriteRenderer.sprite = spriteCollection[0];

    // }

    public void changeSpritePrev()
    {
        //if first sprite
        if(current == 0)
        {
            return;
        }
        else
        {
            current -= 1;
            spriteRenderer.sprite = spriteCollection[current];
        }

        
    }

    public void changeSpriteNext()
    {
        //if last sprite
        if(current == spriteCollection.Count-1)
        {
            if(switchend == true)
            {
                ScenesManager.Instance.LoadNextScene();
            }
            return;
        }
        else
        {
            current += 1;
            spriteRenderer.sprite = spriteCollection[current];
        }
       
    }
}
