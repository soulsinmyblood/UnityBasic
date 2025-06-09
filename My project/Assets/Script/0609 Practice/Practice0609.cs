using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using System.Collections;
using System.Collections.Generic;

// [System.Serializable]
[System.Serializable]
public class Character
{
    public string characterName;
    public Sprite characterImage; 
}

public class Practice0609 : MonoBehaviour
{
    // 인스펙터 창에서 설정할 모든 캐릭터의 목록
    public List<Character> characterPool = new List<Character>();

    // UI 요소
    [Header("UI Elements")]
    public Image characterImageUI;      // 뽑힌 캐릭터 이미지를 표시할 UI Image
    public TextMeshProUGUI characterNameUI; // 뽑힌 캐릭터 이름을 표시할 UI TextMeshPro
    public Button gachaButton;          // 뽑기를 시작할 UI Button

    // 시스템 상태 변수
    private bool isGachaActive = false; // 현재 뽑기가 진행 중인지 확인 (중복 클릭 방지)

    void Start()
    {
        // 초기 설정
        // 버튼이 눌렸을 때 OnGachaButtonPressed 함수가 실행되도록 연결
        if (gachaButton != null)
        {
            gachaButton.onClick.AddListener(OnGachaButtonPressed);
        }

        // 처음에는 이미지와 텍스트를 초기 상태로 설정
        if (characterImageUI != null)
        {
            characterImageUI.gameObject.SetActive(false); // 처음엔 이미지 숨기기
        }
        if (characterNameUI != null)
        {
            characterNameUI.text = "버튼을 눌러 뽑기를 시작하세요!";
        }
    }

    
    // 뽑기 버튼이 눌렸을 때 호출되는 함수
    public void OnGachaButtonPressed()
    {
        if (!isGachaActive && characterPool.Count > 0)
        {
            // 코루틴을 사용하여 10연차 뽑기 실행
            StartCoroutine(PerformTenPull());
        }
        else if (characterPool.Count == 0)
        {
            Debug.LogError("캐릭터 풀(Character Pool)에 캐릭터가 없습니다! 인스펙터에서 캐릭터를 추가해주세요.");
            characterNameUI.text = "뽑을 수 있는 캐릭터가 없습니다.";
        }
    }

    // 10연차 뽑기를 순차적으로 보여주고 마지막에 결과를 요약하는 코루틴
    private IEnumerator PerformTenPull()
    {
        isGachaActive = true; // 상태를 '뽑기 진행 중'으로 변경
        gachaButton.interactable = false; // 뽑기 중에는 버튼 비활성화
        characterImageUI.gameObject.SetActive(true); // 이미지 표시 영역 활성화

        // 뽑은 캐릭터의 이름과 횟수를 기록할 Dictionary 생성
        Dictionary<string, int> gachaResults = new Dictionary<string, int>();

        Debug.Log("====10연차 뽑기를 시작합니다!====");

        // 10번 반복
        for (int i = 0; i < 10; i++)
        {
            // 1. 캐릭터 풀에서 랜덤으로 캐릭터 하나 선택
            int randomIndex = Random.Range(0, characterPool.Count);
            Character drawnCharacter = characterPool[randomIndex];

            // 2. UI 업데이트
            characterImageUI.sprite = drawnCharacter.characterImage;
            characterNameUI.text = drawnCharacter.characterName;

            // 3. 콘솔에 결과 기록
            Debug.Log($"[{i + 1}/10] \"{drawnCharacter.characterName}\"을(를) 뽑았습니다!");

            // 4. 결과 기록하기
            if (gachaResults.ContainsKey(drawnCharacter.characterName))
            {
                gachaResults[drawnCharacter.characterName]++; // 이미 뽑힌 적 있으면 횟수 증가
            }
            else
            {
                gachaResults.Add(drawnCharacter.characterName, 1); // 처음 뽑혔으면 새로 추가
            }

            // 5. 다음 캐릭터를 보여주기 전 잠시 대기 (1초)
            yield return new WaitForSeconds(1f);
        }

        Debug.Log("====10연차 뽑기 완료!====");

        // 최종 결과 정리 및 출력
        // StringBuilder를 사용하여 여러 줄의 문자열 생성
        System.Text.StringBuilder resultTextBuilder = new System.Text.StringBuilder();
        resultTextBuilder.AppendLine("<b>--- 뽑기 결과 요약 ---</b>"); 

        foreach (KeyValuePair<string, int> result in gachaResults)
        {
            resultTextBuilder.AppendLine($"{result.Key} x{result.Value}");
        }

        // 최종 결과를 콘솔과 UI Text에 표시
        Debug.Log(resultTextBuilder.ToString());
        characterNameUI.text = resultTextBuilder.ToString();

        // 뽑기 완료 후 상태 변경
        isGachaActive = false; // 상태를 '대기 중'으로 변경
        gachaButton.interactable = true; // 버튼 다시 활성화
    }
}
