using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives;
    Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLives()
    {
        lives -= 1;
        UpdateDisplay();        

        if (lives <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadLooseScreen();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
                                     