using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    // public static GameManager instance; // 싱글톤을 할당할 전역 변수
    public int ScoreIncreaseAmount = 1;

    public UnityEvent<int> OnscoreChanged = new UnityEvent<int>();
/*    public event UnityAction<int> OnscoreChanged2;*/

    public UnityEvent GameOver = new UnityEvent();
/*    public event UnityAction GameOver2;*/


    public int CurrentScore
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            OnscoreChanged.Invoke(score);
/*            OnscoreChanged2?.Invoke(score);*/
        }
    }
    //void SetScore(int value) { score = value; };
    private int score = 0;
    private bool isGameover = false; // 게임 오버 상태

    /*private void Awake() //어웨이크는 가상함수가 아니다
    {
    }*/
    /*public GameScene gameScene = null;
    public void SetGameScene(GameScene gs)
    {
        gameScene = gs;
    }*/
    void Update()
    {
        if(isGameover && Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    // 점수를 증가시키는 메서드
    public void AddScore()
    {
        CurrentScore += ScoreIncreaseAmount;
    }

    // 플레이어 캐릭터가 사망시 게임 오버를 실행하는 메서드
    public void OnPlayerDead()
    {
        /*gameScene.hudUI.GameOver();*/
        isGameover = true;
        GameOver.Invoke();
/*        GameOver2?.Invoke();*/
    }

    public void foo()
    {
        Debug.Log($"{gameObject} Foo");
    }

    private void Reset()
    {
        CurrentScore = 0;
        isGameover = false;
        /*gameScene.Init();*/
    }
}