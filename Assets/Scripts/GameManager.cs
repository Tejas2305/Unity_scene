using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public enum GameState { Lobby, FriendsMenu, RoomWaiting, QuickMatch }
    private GameState currentState;

    [Header("Panels")]
    public GameObject lobbyPanel;
    public GameObject friendsMenuPanel;
    public GameObject roomWaitingPanel;
    public GameObject joinRoomPanel;

    [Header("Lobby UI")]
    public Button playFriendsButton;
    public Button playRandomButton;

    [Header("Friends Menu UI")]
    public Button createRoomButton;
    public Button joinRoomButton;
    public Button backFromFriendsButton;

    [Header("Join Room UI")]
    public TMP_InputField roomIdInput;
    public Button goButton;

    [Header("Room Waiting UI")]
    public TMP_Text roomCodeText;
    public TMP_Text playersJoinedText;
    public TMP_Text statusText;
    public Button startGameButton;
    public Button backFromRoomButton;
    public GameObject player1Avatar;
    public GameObject player2Avatar;
    public Image player1AvatarBg;
    public Image player2AvatarBg;
    public GameObject player1Icon;
    public GameObject player2Icon;
    public GameObject player2Question;

    private string roomCode;
    private int joinedPlayers = 1;
    private int maxPlayers = 2;
    private bool isQuickMatch = false;

    void Start()
    {
        // Wire up button listeners
        playFriendsButton.onClick.AddListener(OnPlayWithFriends);
        playRandomButton.onClick.AddListener(OnPlayRandom);
        createRoomButton.onClick.AddListener(OnCreateRoom);
        joinRoomButton.onClick.AddListener(OnShowJoinRoom);
        goButton.onClick.AddListener(OnJoinRoom);
        startGameButton.onClick.AddListener(OnStartGame);
        backFromFriendsButton.onClick.AddListener(OnBackToLobby);
        backFromRoomButton.onClick.AddListener(OnBackToLobby);

        // Setup input field
        roomIdInput.characterLimit = 6;
        roomIdInput.onValueChanged.AddListener(OnRoomIdChanged);

        // Start in lobby
        SwitchState(GameState.Lobby);
    }

    void OnRoomIdChanged(string value)
    {
        // Force uppercase and alphanumeric only
        string filtered = "";
        foreach (char c in value.ToUpper())
        {
            if ((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                filtered += c;
            }
        }
        roomIdInput.text = filtered;

        // Enable GO button only if 6 characters
        goButton.interactable = filtered.Length == 6;
    }

    public void SwitchState(GameState newState)
    {
        currentState = newState;

        // Hide all panels
        lobbyPanel.SetActive(false);
        friendsMenuPanel.SetActive(false);
        roomWaitingPanel.SetActive(false);
        joinRoomPanel.SetActive(false);

        // Show appropriate panel
        switch (newState)
        {
            case GameState.Lobby:
                lobbyPanel.SetActive(true);
                ResetState();
                break;
            case GameState.FriendsMenu:
                friendsMenuPanel.SetActive(true);
                break;
            case GameState.RoomWaiting:
            case GameState.QuickMatch:
                roomWaitingPanel.SetActive(true);
                SetupRoom();
                break;
        }
    }

    void ResetState()
    {
        roomCode = "";
        joinedPlayers = 1;
        isQuickMatch = false;
        roomIdInput.text = "";
        goButton.interactable = false;
    }

    void OnPlayWithFriends()
    {
        SwitchState(GameState.FriendsMenu);
    }

    void OnPlayRandom()
    {
        isQuickMatch = true;
        roomCode = "RANDOM";
        SwitchState(GameState.QuickMatch);
        // Simulate finding match after delay
        StartCoroutine(SimulateQuickMatch());
    }

    IEnumerator SimulateQuickMatch()
    {
        yield return new WaitForSeconds(1.5f);
        roomCode = GenerateRoomCode();
        SetupRoom();
    }

    void OnCreateRoom()
    {
        isQuickMatch = false;
        roomCode = GenerateRoomCode();
        SwitchState(GameState.RoomWaiting);
    }

    void OnShowJoinRoom()
    {
        joinRoomPanel.SetActive(true);
        joinRoomButton.interactable = false;
    }

    void OnJoinRoom()
    {
        if (roomIdInput.text.Length == 6)
        {
            isQuickMatch = false;
            roomCode = roomIdInput.text.ToUpper();
            SwitchState(GameState.RoomWaiting);
        }
    }

    void OnBackToLobby()
    {
        SwitchState(GameState.Lobby);
        joinRoomPanel.SetActive(false);
        joinRoomButton.interactable = true;
    }

    void SetupRoom()
    {
        // Update room code display
        roomCodeText.text = roomCode;

        // Reset players
        joinedPlayers = 1;
        UpdatePlayerDisplay();

        // Disable start button initially
        startGameButton.interactable = false;

        // Simulate second player joining after 3 seconds
        StartCoroutine(SimulatePlayerJoin());
    }

    void UpdatePlayerDisplay()
    {
        playersJoinedText.text = $"{joinedPlayers}/{maxPlayers} PLAYERS JOINED";

        // Update player 1 (always ready)
        player1AvatarBg.color = new Color(0.133f, 0.545f, 0.133f); // Green
        player1Icon.SetActive(true);

        // Update player 2
        if (joinedPlayers >= 2)
        {
            player2AvatarBg.color = new Color(0.133f, 0.545f, 0.133f); // Green
            player2Icon.SetActive(true);
            player2Question.SetActive(false);
            statusText.text = "Ready to start!";
            startGameButton.interactable = true;
        }
        else
        {
            player2AvatarBg.color = new Color(0.75f, 0.75f, 0.75f); // Gray
            player2Icon.SetActive(false);
            player2Question.SetActive(true);
            statusText.text = "Waiting for an opponent...";
            startGameButton.interactable = false;
        }
    }

    IEnumerator SimulatePlayerJoin()
    {
        yield return new WaitForSeconds(3f);
        joinedPlayers = 2;
        UpdatePlayerDisplay();
    }

    string GenerateRoomCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string code = "";
        for (int i = 0; i < 6; i++)
        {
            code += chars[Random.Range(0, chars.Length)];
        }
        return code;
    }

    void OnStartGame()
    {
        Debug.Log($"Starting game for room: {roomCode}");
        // TODO: Load actual gameplay scene here
    }
}
