using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.VFX;
public class Lose : MonoBehaviour
{
    private VisualElement LoseElement;

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        LoseElement = root.Q<VisualElement>("Lose");

        LoseElement.style.display = DisplayStyle.Flex;
        Button RePlay = root.Q<Button>("RePlay");
        RePlay.RegisterCallback<ClickEvent>(rePlay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void rePlay(ClickEvent cke)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
