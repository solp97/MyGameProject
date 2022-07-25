using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public float MyScore { get; private set; }
    public bool IsOn { get; set; }

    TMPro.TextMeshProUGUI _uiText;

    private float _Time;

    // Start is called before the first frame update
    void Start()
    {
        _uiText = GetComponent<TMPro.TextMeshProUGUI>();
        IsOn = true;
    }

    private void OnEnable()
    {
        GameManager.Instance.OnscoreChanged.AddListener(UpdateText);
/*        GameManager.Instance.OnscoreChanged2 -= UpdateText;
        GameManager.Instance.OnscoreChanged2 += UpdateText;*/
    }

    // Update is called once per frame
    public void UpdateText(int score)
    {
         _uiText.text = $"Score : {score}";
    }

    private void OnDisable()
    {
        GameManager.Instance.OnscoreChanged.RemoveListener(UpdateText);

/*      GameManager.Instance.OnscoreChanged2 -= UpdateText;*/
    }
}
