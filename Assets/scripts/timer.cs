using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{
    public TextMeshProUGUI timerText; // Text UI เพื่อแสดงเวลา
    private float timer = 0f; // ตัวแปรสำหรับเก็บเวลาที่ผ่านไป
    private bool isTimerRunning = true; // ควบคุมสถานะของ Timer

    void Update(){
        if (isTimerRunning){
            timer += Time.deltaTime; // เพิ่มเวลาในแต่ละเฟรม
            UpdateTimerDisplay();
        }
    }
    // ฟังก์ชันสำหรับแปลงเวลาเป็นรูปแบบนาที:วินาที
    private void UpdateTimerDisplay(){
        int minutes = Mathf.FloorToInt(timer / 60); // แปลงเวลาเป็นนาที
        int seconds = Mathf.FloorToInt(timer % 60); // หาเวลาส่วนที่เหลือเป็นวินาที
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // อัปเดตข้อความ
    }
}
