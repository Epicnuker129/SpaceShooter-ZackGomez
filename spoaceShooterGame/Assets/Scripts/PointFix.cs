using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointFix : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;
    [SerializeField]
    private int WinPointCount;
    // point zero out
    private int PointCounter;
    //the bools that trigger if player wins or dies
    //V DONT NEED ANYMORE
    //private bool Winner = false;
  //  private bool Dead = false;
    // Start is called before the first frame update

    //attempting to cast integer to text
    public Text PointCounting;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PointCounting.text = PointCounter.ToString();
        if (PointCounter == WinPointCount)
        {
            SceneManager.LoadScene(2);

        }
    }
    public void SetPointo(int pointset)
    {
        PointCounter += pointset;
        Debug.Log("add point");
    }
}
