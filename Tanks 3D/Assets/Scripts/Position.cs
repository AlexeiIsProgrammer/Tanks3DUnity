using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Position : MonoBehaviour
{
    private bool y = true;
    private int kol = 0;
    private Vector3 pos1, pos2, pos3;
    private Quaternion rot1, rot2, rot3;
    public GameObject MediumTank, HardTank, FastTank;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = FastTank.transform.position;
        rot1 = FastTank.transform.rotation;

        pos2 = MediumTank.transform.position;
        rot2 = MediumTank.transform.rotation;

        pos2 = HardTank.transform.position;
        rot2 = HardTank.transform.rotation;
    }

    private void CreateMediumTank()
    {
        GameObject newTank1 = Instantiate(MediumTank, pos1, rot1);
        newTank1.SetActive(true);
    }
    private void CreateFastTank()
    {
        GameObject newTank1 = Instantiate(FastTank, pos2, rot2);
        newTank1.SetActive(true);
    }
    private void CreateHardTank()
    {
        GameObject newTank1 = Instantiate(HardTank, pos3, rot3);
        newTank1.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 2:
                if (NewBehaviourScript.tanksKills == 0 && kol<1)
                {
                    CreateFastTank();
                    CreateFastTank();

                    kol++;
                }
                else if(NewBehaviourScript.tanksKills == 2 && kol < 2)
                {
                    CreateMediumTank();
                    CreateFastTank();
                    CreateFastTank();

                    kol++;
                    
                }
                if (NewBehaviourScript.tanksKills == 5 && kol == 2)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 3:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 3 && kol == 1)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 7 && kol == 2)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                if (NewBehaviourScript.tanksKills == 11 && kol == 3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 4:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();
                    CreateFastTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 4 && kol == 1)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 8 && kol == 2)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateHardTank();

                    kol++;
                   
                }
                if (NewBehaviourScript.tanksKills == 11 && kol == 3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 5:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 5 && kol == 1)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 11 && kol == 2)
                {
                    CreateHardTank();
                    CreateMediumTank();

                    kol++;
                   
                }
                if (NewBehaviourScript.tanksKills == 13 && kol == 3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 6:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateHardTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 4 && kol == 1)
                {
                    CreateFastTank();
                    CreateHardTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 7 && kol == 2)
                {
                    CreateHardTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                    
                }
                if (NewBehaviourScript.tanksKills == 10 && kol == 3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 7:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateFastTank();
                    CreateFastTank();
                    CreateMediumTank();
                    CreateHardTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 4 && kol == 1)
                {
                    CreateFastTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateHardTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 8 && kol == 2)
                {
                    CreateHardTank();
                    CreateHardTank();

                    kol++;
                    
                }
                if (NewBehaviourScript.tanksKills == 10 && kol == 3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 8:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateHardTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 3 && kol == 1)
                {
                    CreateHardTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 7 && kol == 2)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                    
                }
                if (NewBehaviourScript.tanksKills == 12 && kol == 3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 9:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateFastTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 6 && kol == 1)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 12 && kol == 2)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();

                    kol++;
                }
                if (NewBehaviourScript.tanksKills == 16 && kol == 3)
                {

                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
            case 10:
                if (NewBehaviourScript.tanksKills == 0 && kol == 0)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();
                    CreateMediumTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 7 && kol == 1)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();

                    kol++;
                }
                else if (NewBehaviourScript.tanksKills == 11 && kol == 2)
                {
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();
                    CreateHardTank();

                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();
                    CreateMediumTank();

                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();
                    CreateFastTank();

                    kol++;
                    
                }
                if(NewBehaviourScript.tanksKills == 26 && kol==3)
                {
                    NewBehaviourScript.tankBool = true;
                    NewBehaviourScript.WinBlock();
                }
                break;
        }

        
    }
}
