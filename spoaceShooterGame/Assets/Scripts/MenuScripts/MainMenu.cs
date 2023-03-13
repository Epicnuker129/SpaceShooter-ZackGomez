using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isQuit;
	public bool isRestart;
    void Start()
    {
    }
	void OnMouseUp()
	{
		if (isStart)
		{
			SceneManager.LoadScene(1);
		}
		if (isQuit)
		{
			Application.Quit();
		}
		if(isRestart)
        {
			SceneManager.LoadScene(0);
		}
	}
}
