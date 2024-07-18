using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIMinimap : MonoBehaviour
{
    [SerializeField]
    private Camera minimapCamera; // 미니맵 카메라
    [SerializeField]
    private float zoomMin = 1; // 미니맵 최소값
    [SerializeField]
    private float zoomMax = 30; // 미니맵 최대값
    [SerializeField]
    private float zoomOneStep = 1; // 미니맵 축소 확대 단위
    [SerializeField]
    private TextMeshProUGUI textMapName;
    //SceneManager.GetActiveScene().name; // 현재 씬의 이름
    //orthographicsize 오쏘그래픽 카메라의 싸이즈
    private void Awake()
    {
        //맵 이름을 현재 씬 이름으로 설정
        textMapName.text = SceneManager.GetActiveScene().name;
    }
    public void ZoomIn()
    {
        minimapCamera.orthographicSize = Mathf.Max(minimapCamera.orthographicSize - zoomOneStep, zoomMin);
        //카메라의 orthographicSize 값을 감소시켜 카메라에 보이는 사물 크기 확대
    }
    public void ZoomOut()
    {
        minimapCamera.orthographicSize = Mathf.Min(minimapCamera.orthographicSize + zoomOneStep, zoomMax);
        //카메라의 orthographicSize 값을 증가시켜 카메라에 보이는 사물 크기 축소
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
