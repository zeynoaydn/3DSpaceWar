using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject gamemenu;
    public GameObject move;
    public GameObject gun;
    public GameObject gun2;
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (gamemenu.activeSelf == false)
            {
                MonoBehaviour[] scriptList = move.GetComponents<MonoBehaviour>();
                for (int i = 0; i < scriptList.Length; i++)
                {
                    scriptList[i].enabled = false;
                }
                MonoBehaviour[] scriptList1 = gun.GetComponents<MonoBehaviour>();
                foreach (MonoBehaviour script1 in scriptList1)
                {
                    script1.enabled = false;
                }
                MonoBehaviour[] scriptList2 = gun2.GetComponents<MonoBehaviour>();
                foreach (MonoBehaviour script2 in scriptList2)
                {
                    script2.enabled = false;
                }
                Time.timeScale = 1.0f;
                gamemenu.active = true;
            }
            else
            {
                MonoBehaviour[] scriptList = move.GetComponents<MonoBehaviour>();
                foreach (MonoBehaviour script in scriptList)
                {
                    script.enabled = true;
                }
                MonoBehaviour[] scriptList1 = gun.GetComponents<MonoBehaviour>();
                foreach (MonoBehaviour script1 in scriptList1)
                {
                    script1.enabled = true;
                }
                MonoBehaviour[] scriptList2 = gun2.GetComponents<MonoBehaviour>();
                foreach (MonoBehaviour script2 in scriptList2)
                {
                    script2.enabled = true;
                }
                Time.timeScale = 0.0f;
                gamemenu.active = false;
            }
        }
    }
    
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void devamet()
    {
        Time.timeScale = 1f;
        gamemenu.active = false;
        MonoBehaviour[] scriptList = move.GetComponents<MonoBehaviour>();
        for (int i = 0; i < scriptList.Length; i++)
        {
            scriptList[i].enabled = true;
        }
        MonoBehaviour[] scriptList1 = gun.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script1 in scriptList1)
        {
            script1.enabled = true;
        }
        MonoBehaviour[] scriptList2 = gun2.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script2 in scriptList2)
        {
            script2.enabled = true;
        }
        gamemenu.active = false;
    }
    
}
    //public GameObject gamem;
    //void Start()
    //{

    //}
    //void Update()
    //{
    //    Move move = gamem.GetComponent<Move>();

    //    if (Input.GetKeyUp(KeyCode.Escape))
    //    {
    //        if (gamem.activeSelf)
    //        {
    //            gamem.SetActive(false);
    //        }
    //        else
    //        {
    //            gamem.SetActive(true);
    //        }
    //        if (Time.timeScale == 1)
    //        {
    //            PauseGame();
    //            move.enabled = false;
    //        }
    //        else
    //        {
    //            ResumeGame();
    //        }
    //    }
    //}
    //void PauseGame()
    //{
    //    Time.timeScale = 0;
    //}
    //void ResumeGame()
    //{
    //    Time.timeScale = 1;
    //}
