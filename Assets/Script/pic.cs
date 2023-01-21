using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pic : Sounds
{
    public Sounds sh;
    
    public Image OldImage;
    public Sprite NewImage;
    private void Start()
    {


    }
    public void changePic()
    {
        OldImage.sprite = NewImage;
        SoundPlayer(1, 5);
        StartCoroutine(waiter(3));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }
    IEnumerator waiter(int x)
    {
        yield return new WaitForSeconds(x);
    }

}
