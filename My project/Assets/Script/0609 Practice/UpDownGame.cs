using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
using TMPro;    

public class UpDownGame : MonoBehaviour
{
    // UI 요소
    [Header("UI 요소")]
    public TMP_InputField userInputField; // 사용자 숫자 입력 필드
    public Button submitButton; // 제출 버튼
    public TextMeshProUGUI resultLogText; // 결과 로그를 표시할 텍스트
    public TextMeshProUGUI tryCountText; // 시도 횟수를 표시할 텍스트

    // 게임 상태 변수들
    private int targetNumber; // 맞춰야 할 숫자  
    private int tryCount; // 시도 횟수
    private bool isGameFinished; // 게임 종료 여부
    private List<string> resultLogs; // 결과 로그를 저장할 리스트

    // 게임이 시작될 때 한번만 호출되는 함수
    private void Start()
    {
        // OnClick()에 연결을 대신
        submitButton.onClick.AddListener(OnSubmitionButtonClicked);

        // 결과 로그를 저장할 리스트 초기화
        resultLogs = new List<string>();

        // 새 게임 시작
        StartNewGame();
    }

    void StartNewGame() 
    {
        // 1. 1부터 100 사이의 랜덤 숫자 생성
        targetNumber = Random.Range(1, 101);

        // 2. 변수 초기화
        tryCount = 0;
        isGameFinished = false;
        resultLogs.Clear(); // 이전 게임의 로그를 초기화

        // 3. UI 초기화
        userInputField.text = ""; // 입력 필드 초기화
        userInputField.interactable = true; // 입력 필드 활성화
        submitButton.interactable = true; // 제출 버튼 활성화  
        resultLogText.text = "1~100 사이의 숫자를 맞춰보세요!";
        tryCountText.text = "시도 횟수: 0"; // 시도 횟수 초기화

        // 정답을 콘솔에 출력
        Debug.Log("정답: " + targetNumber);
    }

    // 제출 버튼이 클릭되었을 때 호출되는 함수
    public void OnSubmitionButtonClicked() 
    {
        // 게임이 끝나면 호출X
        if (isGameFinished) return;

        // 입력창에 있는 텍스트 가져오기
        string inputText = userInputField.text;

        // 입력된 텍스트를 숫자로 변환
        int guessNumber;
        if (!int.TryParse(inputText, out guessNumber) || guessNumber < 1 || guessNumber > 100) 
        {
            // 숫자로 변환 실패하거나 범위를 벗어난 경우
            resultLogText.text = "1부터 100 사이의 숫자를 입력하세요!";
            return; // 유효하지 않은 입력
        }

        // 시도 횟수 증가 +1
        tryCount++;
        tryCountText.text = $"시도 횟수: {tryCount}";

        // 플레이어가 입력한 숫자와 정답 비교
        string currentLog;
        if (guessNumber > targetNumber) 
        {
            // 입력한 숫자가 정답보다 큰 경우
            currentLog = $"{guessNumber}는(은) 정답보다 큽니다. 다시 시도하세요.";
        }

        else if (guessNumber < targetNumber) 
        {
            // 입력한 숫자가 정답보다 작은 경우
            currentLog = $"{guessNumber}는(은) 정답보다 작습니다. 다시 시도하세요.";
        }
        else 
        {
            // 정답을 맞춘 경우
            currentLog = $"축하합니다! {guessNumber}가 정답입니다!";
            isGameFinished = true; // 게임 종료 상태로 변경
            userInputField.interactable = false; // 입력 필드 비활성화
            submitButton.interactable = false; // 제출 버튼 비활성화
        }

        // 결과 로그에 현재 시도 기록 추가
        resultLogs.Insert(0, currentLog); // 최신 기록을 가장 위에 추가

        // 결과 로그를 UI에 표시
        UpdateResultLogText();

        userInputField.text = ""; // 입력 필드 초기화
    }

    // resultLogs 리스트에 있는 모든 로그를 UI에 표시하는 함수
    void UpdateResultLogText() 
    {
        // 리스트에 있는 모든 문자열을 한 줄씩 띄어서 하나의 문자열로 만듦
        resultLogText.text = string.Join("\n", resultLogs);

        // 게임이 종료되면 최종 메시지 추가!
        if (isGameFinished) 
        { 
            resultLogText.text += "\n게임이 종료되었습니다! \n<b>{tryCount}번 만에 맞추셨습니다! 새 게임을 시작하려면 다시 시작 버튼을 눌러주세요.";
        }
    }

}
