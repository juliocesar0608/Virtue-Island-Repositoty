using System.Collections;
using Unity.VisualScripting;
using UnityEditor.ShortcutManagement;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChestPuzzleMechanic : MonoBehaviour
{
    [Header("Chest Puzzle Interface")]
    public GameObject Crystal;
    public GameObject PuzzleInterface;
    public RawImage ButtonColor1;
    public RawImage ButtonColor2;
    public RawImage ButtonColor3;



    bool PlayerIsClose = false;

    int FirstButton;
    int SecondButton;
    int ThirdButton;

    bool PuzzleCleared = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FirstButton = 4;
        SecondButton = 3;
        ThirdButton = 5;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeButtonColor();

        if (Input.GetKeyDown(KeyCode.E) && PlayerIsClose)
        {
            PuzzleInterface.SetActive(true);
        }

        if(FirstButton == 1 && SecondButton == 2 && ThirdButton ==3)
        {
            PuzzleCleared = true;
        }

        if(PuzzleCleared)
        {
            PuzzleInterface.SetActive(false);
            Crystal.SetActive(true);
        }
    }

    public void LeavePuzzle()
    {
        {
            PuzzleInterface.SetActive(false);
        } 
    }

   // Implementar a mecanica de primeira pessoa
 
    public void ChangeButtonCombination(int Button)
    {
        switch (Button)
        {
            case 1:
                FirstButton--;
                break;
            case 2:
                SecondButton--;
                break;
            case 3:
                ThirdButton--;
                break;
            case 4:
                FirstButton++;
                break;
            case 5:
                SecondButton++;
                break;
            case 6: 
                ThirdButton++;
                break;
        }
    }

    
    private void ChangeButtonColor()
    {
        if(FirstButton == 1)
        {
            ButtonColor1.color = Color.green;
        }
       

        if (FirstButton == 2)
        {
            ButtonColor1.color = Color.blue;
        }

        if(FirstButton == 3)
        {
            ButtonColor1.color = Color.red;
        }

        if (FirstButton == 4)
        {
            ButtonColor1.color = Color.yellow;
        }

        if(FirstButton == 5)
        {
            ButtonColor1.color = Color.purple;
        }
  
        if(FirstButton < 1)
        {
            ButtonColor1.color = Color.purple;
            FirstButton = 5;
        }

        if(FirstButton > 5)
        {
            ButtonColor1.color = Color.green;
            FirstButton = 1;
        }

        ///////////////////////////////////////////

        if (SecondButton == 1)
        {
            ButtonColor2.color = Color.green;
        }
       

        if (SecondButton == 2)
        {
            ButtonColor2.color = Color.blue;
        }

        if (SecondButton == 3)
        {
            ButtonColor2.color = Color.red;
        }

        if (SecondButton == 4)
        {
            ButtonColor2.color = Color.yellow;
        }

        if(SecondButton == 5)
        {
            ButtonColor2.color = Color.purple;
        }
        
        if (SecondButton < 1)
        {
            ButtonColor2.color = Color.purple;
            SecondButton = 5;
        }

        if(SecondButton > 5)
        {
            ButtonColor2.color = Color.green;
            SecondButton = 1;
        }  
        
        //////////////////////////////////////////

        if (ThirdButton == 1)
        {
            ButtonColor3.color = Color.green;
        }

        if (ThirdButton == 2)
        {
            ButtonColor3.color = Color.blue;
        }

        if (ThirdButton == 3)
        {
            ButtonColor3.color = Color.red;
        }

        if (ThirdButton == 4)
        {
            ButtonColor3.color = Color.yellow;
        }

        if (ThirdButton == 5)
        {
            ButtonColor3.color = Color.purple;
        }

        if (ThirdButton < 1)
        {
            ButtonColor3.color = Color.purple;
            ThirdButton = 5;
        }

        if (ThirdButton > 5)
        {
            ButtonColor3.color = Color.green;
            ThirdButton = 1;
        }
       

    }

   

}
