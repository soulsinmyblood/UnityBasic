using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DynamicTextboxManager : MonoBehaviour
{
    [Header("UI 요소 연결")]
    public TMP_InputField messageInput;   // 사용자 입력을 받을 InputField
    public TextMeshProUGUI messageText; // 말풍선 안에 표시될 TextMeshPro UI
    public Button sendButton;             // 메시지 전송(업데이트) 버튼

    void Start()
    {
        // 버튼이 할당되어 있고, 클릭 이벤트에 함수 등록
        if (sendButton != null)
        {
            sendButton.onClick.AddListener(UpdateMessage);
        }
        else
        {
            Debug.LogError("Send Button이 스크립트에 연결되지 않았습니다.");
        }

        // 유효성 검사
        if (messageInput == null)
        {
            Debug.LogError("Message Input Field가 스크립트에 연결되지 않았습니다.");
        }
        if (messageText == null)
        {
            Debug.LogError("Message Text (TextMeshPro)가 스크립트에 연결되지 않았습니다.");
        }
        else
        {
            // 게임 시작 시 초기 텍스트 설정
            messageText.text = "말풍선 크기가 텍스트 길이에 따라 자동으로 조절됩니다.";
        }
    }

    /// <summary>
    /// 버튼 클릭 시 호출되어 InputField의 내용을 TextMeshPro에 업데이트하는 함수
    /// </summary>
    private void UpdateMessage()
    {
        // InputField가 비어있지 않은 경우에만 텍스트를 업데이트합니다.
        if (messageInput != null && !string.IsNullOrEmpty(messageInput.text))
        {
            messageText.text = messageInput.text;

            // 전송 후 입력 필드를 비웁니다.
            messageInput.text = "";

            // 입력 필드를 다시 활성화하여 바로 다음 입력을 할 수 있도록 합니다 (선택 사항).
            messageInput.ActivateInputField();
        }
    }

    /// <summary>
    /// 스크립트가 파괴될 때 등록된 리스너를 제거하여 메모리 누수를 방지합니다.
    /// </summary>
    void OnDestroy()
    {
        if (sendButton != null)
        {
            sendButton.onClick.RemoveListener(UpdateMessage);
        }
    }
}
