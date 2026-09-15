using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoParaMenu : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public string nomeDaCena = "TelaInicial"; // Nome exato da sua cena

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        
        // Dispara a troca de cena quando o vídeo chegar ao fim
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += MudarDeCena;
        }
    }

    void Update()
    {
        // Opcional: Pula o vídeo se o jogador pressionar qualquer tecla ou clicar
        if (Input.anyKeyDown)
        {
            MudarDeCena(videoPlayer);
        }
    }

    void MudarDeCena(VideoPlayer vp)
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}