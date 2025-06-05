using UnityEngine;
using UnityEngine.UI; // UI 관련 클래스 사용

public class ResultDisplayManager : MonoBehaviour
{
    [Header("UI 요소 연결")]
    public Button confirmResultButton; // 인스펙터에서 'ConfirmResultButton' UI 버튼을 연결.
    public Image youDiedImage;       // 인스펙터에서 'YouDied' UI 이미지를 연결
    public Image victoryImage;       // 인스펙터에서 'Victory' UI 이미지를 연결

    private bool hasPlayerWon = false;

    void Start()
    {
        // 1. 시작 시 모든 결과 이미지를 숨기기
        if (youDiedImage != null)
        {
            youDiedImage.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("YouDied 이미지가 ResultDisplayManager 스크립트에 연결되지 않음!");
        }

        if (victoryImage != null)
        {
            victoryImage.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("Victory 이미지가 ResultDisplayManager 스크립트에 연결되지 않음!");
        }

        // 2. 버튼 클릭 이벤트에 함수 등록
        if (confirmResultButton != null)
        {
            // 버튼이 클릭되면 ShowOutcome 함수를 호출
            confirmResultButton.onClick.AddListener(ShowOutcome);
        }
        else
        {
            Debug.LogError("ConfirmResultButton이 ResultDisplayManager 스크립트에 연결되지 않음!");
        }
    }

    // 승패 상태를 결정
    public void SetPlayerWinStatus(bool playerWins)
    {
        hasPlayerWon = playerWins;
    }

    // 버튼 클릭 시 호출될 함수
    void ShowOutcome()
    {
        // 모든 결과 이미지를 다시 숨겨서 중복 표시 방지
        if (youDiedImage != null) youDiedImage.gameObject.SetActive(false);
        if (victoryImage != null) victoryImage.gameObject.SetActive(false);
        SimulateRandomOutcomeOnClick(); // 버튼 클릭 시 랜덤 결과 생성

        if (hasPlayerWon)
        {
            if (victoryImage != null)
            {
                victoryImage.gameObject.SetActive(true);
                Debug.Log("승리! Victory 이미지 표시.");
            }
        }
        else
        {
            if (youDiedImage != null)
            {
                youDiedImage.gameObject.SetActive(true);
                Debug.Log("패배! YouDied 이미지 표시.");
            }
        }

        // 결과가 표시된 후 버튼을 비활성화
        //confirmResultButton.interactable = false;
    }

    private void SimulateRandomOutcomeOnClick()
    {
        hasPlayerWon = Random.Range(0, 2) == 0; // 0 또는 1 중 랜덤, 0이면 true (승리)
        if (hasPlayerWon)
        {
            Debug.Log("결과 시뮬레이션: 승리");
        }
        else
        {
            Debug.Log("결과 시뮬레이션: 패배");
        }
    }









    //// (선택 사항) 게임 로직에 따라 외부에서 직접 특정 결과를 표시하게 하는 함수들
    //public void DisplayVictoryScreen()
    //{
    //    if (youDiedImage != null) youDiedImage.gameObject.SetActive(false);
    //    if (victoryImage != null) victoryImage.gameObject.SetActive(true);
    //    Debug.Log("Victory 화면이 직접 호출되어 표시됩니다.");
    //}

    //public void DisplayYouDiedScreen()
    //{
    //    if (victoryImage != null) victoryImage.gameObject.SetActive(false);
    //    if (youDiedImage != null) youDiedImage.gameObject.SetActive(true);
    //    Debug.Log("YouDied 화면이 직접 호출되어 표시됩니다.");
    //}
}
