using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    private string name = "정은교";// 이름
    private int age = 18; // 나이
    private float height = 1.66f; // 키
    private bool isStudent = true; // 학생 여부
    private string[] hobbies = { "게임", "독서", "영화 감상" }; // 취미
    private List<string> friends = new List<string> { "민영님", "규진님", "형민님", "민석님" }; // 친구 목록
    private Dictionary<string, int> scores = new Dictionary<string, int> // 과목 점수
    {
        { "레벨 기획", 95 },
        { "콘텐츠 기획", 90 },
        { "시스템 기획", 85 }
    };
    private enum GameGenre // 게임 장르를 정의하는 열거형
    {
        Soulslike,
        Adventure,
        Metroidvania,
        Simulation,
        Rhythm
    }
    private string school = "경일게임IT아카데미"; // 학교 이름
    private string major = "스마트 2기 기획반"; // 전공
    private string studentId = "60"; // 연번
    private string steamId = "76561199534729810"; // 스팀 아이디
    private string game = "Lies of P"; // 좋아하는 게임
    private string favoriteFood = "카이센동"; // 좋아하는 음식
    private string favoriteColor = "네이비"; // 좋아하는 색
    private string favoriteMusic = "Pop"; // 좋아하는 음악 장르
    private int favoriteNumber = 7; // 좋아하는 숫자
    private int numberOfPets = 0; // 반려동물의 수

    // Start is called before the first frame update
    void Start()
    {
        SelfIntroduction(); // 기본 자기소개 호출
    }

    void SelfIntroduction()
    {
        Debug.Log($"안녕하세요, 제 이름은 {name}입니다. 나이는 {age}세이고, 키는 {height}m입니다. 학생 여부는 {isStudent}입니다.");
        Debug.Log($"취미는 {string.Join(", ", hobbies)}입니다.");
        Debug.Log($"좋아하는 음식은 {favoriteFood}입니다. 좋아하는 색은 {favoriteColor}이고, 좋아하는 음악 장르는 {favoriteMusic}이며.  좋아하는 숫자는 {favoriteNumber}입니다.");
        Debug.Log($"제 친구는 {string.Join(", ", friends)}이십니다. (극존칭)");
        Debug.Log($"저희 집 반려동물의 수는 {numberOfPets} 입니다. 저만 반려동물 없어요.");
        Debug.Log($"지금까지 교과목 점수: 레벨 기획 {scores["레벨 기획"]}점, 콘텐츠 기획 {scores["콘텐츠 기획"]}점, 시스템 기획 {scores["시스템 기획"]}점. (이면 좋겠다는 뜻)");
        Debug.Log($"현재 {school}에서 게임 기획을 배우고 있습니다. 제가 속한 반은 {major}이며, 제 연번은 {studentId}입니다.");
        Debug.Log($"좋아하는 게임은 {game}입니다. 이 게임 장르는 제가 좋아하는 {GameGenre.Soulslike}입니다. 스팀 친추는 여기로: {steamId}!");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
