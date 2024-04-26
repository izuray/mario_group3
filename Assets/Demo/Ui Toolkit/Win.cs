using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class Win : MonoBehaviour
{
    private VisualElement WinElement;

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        WinElement = root.Q<VisualElement>("Win");
        WinElement.style.display = DisplayStyle.Flex;
        Button RePlay = root.Q<Button>("RePlay");
        RePlay.RegisterCallback<ClickEvent>(rePlay);
        Button NextLevel = root.Q<Button>("NextLevel");
        NextLevel.RegisterCallback<ClickEvent>(nextLevel);
    }

    private void rePlay(ClickEvent cke)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    private void nextLevel(ClickEvent cke)
    {
        SceneManager.LoadScene("1");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
