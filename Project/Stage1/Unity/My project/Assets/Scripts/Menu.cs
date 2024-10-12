using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    bool inMenu = true;
    [SerializeField] Animator pointerAnimator;
    [SerializeField] Animator menuAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inMenu = !inMenu;
            pointerAnimator.SetBool("InMenu", inMenu);
            menuAnimator.SetBool("inMenu", inMenu);
        }
    }
    // Update is called once per frame

}
