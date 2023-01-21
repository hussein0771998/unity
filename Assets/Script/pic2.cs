using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pic2 : Sounds
{
    public Sounds sh;

    public Image OldImage;
    public Sprite NewImage;
   
    private void Start()
    {
        StartCoroutine(waiter());
        OldImage.sprite = NewImage;

    }
    public void changePic()
    {
       
        SoundPlayer(1, 5);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(10);
    }

}
