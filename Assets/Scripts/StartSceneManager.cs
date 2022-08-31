using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static StartSceneManager Instance;

    public string dogName;
    public string catName;
    public string chickenName;

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(Instance);
    }

    public void onStartButtonPressed()
    {
        TextMeshProUGUI text = GameObject.Find("DogTextInput").GetComponent<TextMeshProUGUI>();
        dogName = text.text;
        text = GameObject.Find("CatTextInput").GetComponent<TextMeshProUGUI>();
        catName = text.text;
        text = GameObject.Find("ChickenTextInput").GetComponent<TextMeshProUGUI>();
        chickenName = text.text;

        SceneManager.LoadScene("SampleScene");
    }


}
