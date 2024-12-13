using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
 [SerializeField] private TMP_Text raqueta1ScoreText;
 [SerializeField] private TMP_Text raqueta2ScoreText;
 
 [SerializeField]private Transform raqueta1Transform;
 [SerializeField]private Transform raqueta2Transform;
 [SerializeField]private Transform bolaTransform;
 
 private int rScorej1;
 private int rScorej2;

 private static GameManager instance;
 public static GameManager Instance
 {
  get
  {
   if (instance == null)
   {
    instance = FindObjectOfType<GameManager>();
   }

   return instance;
  }
 }

 public void Raqueta1Score()
 {
  rScorej1++;
  raqueta1ScoreText.text = rScorej1.ToString();
 }

 public void Raqueta2Score()
 {
  rScorej2++;
  raqueta2ScoreText.text = rScorej2.ToString();
 }

 public void Restart()
 {
  raqueta1Transform.position = new Vector2(raqueta1Transform.position.x, 0);
  raqueta2Transform.position = new Vector2(raqueta2Transform.position.x, 0);
  bolaTransform.position = new Vector2(0, 0);
 }}
