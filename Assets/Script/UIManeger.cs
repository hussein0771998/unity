using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    
    
    private string input;
    public string aname, pass;
    public GameObject Uuser_Name;
    public GameObject Paassword;

    public Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();

       

    }
    void Update()
    {


    }
    public string getInput(string s)
    {
        input = s;
        return input;
    }
    public void anima1()
    {

        anim.SetBool("Uname", true);
        anim.SetBool("Pass", false);
    }
    public void anim2()
    {
        anim.SetBool("Pass", true);
        anim.SetBool("Uname", false);
    }
    public void login()
    {
        // aname = Uuser_Name.GetComponent<Text>().ToString();
        // pass = Paassword.GetComponent<Text>().ToString();
        //if (aname=="Hi" && pass == "123")
        //{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
    }
    
}
