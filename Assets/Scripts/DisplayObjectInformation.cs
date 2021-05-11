using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using ObjectsApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DisplayObjectInformation : MonoBehaviour, IDragHandler
{
    [SerializeField]
    private UnityController unityController;
    [SerializeField]
    private Button closeButton;
    [SerializeField]
    private TextMeshProUGUI dataText;


    public event Action buttonClicked;

    private Vector3 previousPosition;
    private Alarm alarm;

    private void Awake()
    {
        gameObject.SetActive(false);
        closeButton.onClick.AddListener(() => buttonClicked.Invoke());
        DisplayAlarmInfo();
    }

    private void DisplayAlarmInfo()
    {
        if (alarm == null)
        {
            alarm = unityController.alarmService.Get().FirstOrDefault();

            if (alarm == null)
            {
                string id = Guid.NewGuid().ToString();
                Alarm newAlarm = new Alarm(string.Concat("Alarm ", id), id, new List<string>(), true, 1, DateTime.Now);
                alarm = unityController.alarmService.Create(newAlarm);
            }
        }

        dataText.text = $"Name: {alarm.Name}\n Active: {alarm.Active}\n Affects Equipment: {alarm.AffectedEquipment.Any()}\n Time of Failure: {alarm.TimeOfFailure}";

    }

    private void OnMouseDown()
    {
        previousPosition = Input.mousePosition;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position += (Vector3)eventData.delta;
    }
}
